// TextDialog.h
// Created by Kyle N. Lane
// Date : 2/10/14

#ifndef _TEXTDIALOG_H_
#define _TEXTDIALOG_H_

BOOL CALLBACK TextDialogProc(HWND hWndDlg, UINT message, WPARAM wParam, LPARAM lParam);
HWND CreateTextDialog(HINSTANCE mainhInst,HWND mainhWnd,byte *data,DWORD dataSize);
bool InitTextDialog();
bool UpdateTextDialog();
byte *GetTextData(DWORD *len);
byte *ExportTextData(DWORD *len);
bool ImportTextData(byte *data,DWORD len);

HWND hTextDialog;
DWORD textLength;
TCHAR *text;
bool hasChanged=false;

HWND CreateTextDialog(HINSTANCE mainhInst,HWND mainhWnd,byte *data,DWORD dataSize)
{
	DestroyWindow(hTextDialog);
	hTextDialog=CreateDialog(mainhInst,MAKEINTRESOURCE(IDD_TEXTDIALOG),mainhWnd,&TextDialogProc);

	memcpy(&textLength,data,4);

	LEUtilDeleteArray(text);
	text=new TCHAR[textLength+LEMAX_STRING];
	ZeroMemory(text,textLength+LEMAX_STRING);

	mbstowcs(text,(char*)data+4,textLength);
	text[textLength]=0;

	textLength+=LEMAX_STRING;

	InitTextDialog();
	UpdateTextDialog();
	return hTextDialog;
}

BOOL CALLBACK TextDialogProc(HWND hWndDlg, UINT message, WPARAM wParam, LPARAM lParam) 
{
	switch (message) 
	{ 
		case WM_COMMAND:
			{
				switch(HIWORD(wParam)) 
				{
				case EN_CHANGE:
					{
						switch((int)LOWORD(wParam)) 
						{
							case IDC_TEXTEDIT:
							{
								hasChanged=true;
								DWORD length=GetWindowTextLength(GetDlgItem(hWndDlg, IDC_TEXTEDIT));
								if(length>textLength)
								{
									LEUtilDeleteArray(text);
									textLength=length+LEMAX_STRING;
									text=new TCHAR[textLength];
									GetDlgItemText(hWndDlg, IDC_TEXTEDIT,text,textLength);
								}
								else
								{
									GetDlgItemText(hWndDlg, IDC_TEXTEDIT,text,textLength);
								}
							}break;
						}
					}break;
				}
			}break;

		case WM_SIZE:
            {
				RECT client;
				GetClientRect(hWndDlg,&client);
				MoveWindow(GetDlgItem(hWndDlg, IDC_TEXTEDIT), 8, 8, client.right-16, client.bottom-16, true);
            }
            break;

		case WM_DESTROY:
			{
				LEUtilDeleteArray(text);
			}
			break;

		default: 
			return false;
	} 
	return false;
}

bool InitTextDialog()
{
	hasChanged=false;

	SendMessage(GetDlgItem(hTextDialog, IDC_TEXTEDIT), EM_LIMITTEXT, (WPARAM)0,0);

	return true;
}

bool UpdateTextDialog()
{
	SetDlgItemText(hTextDialog,IDC_TEXTEDIT,text);

	return true;
}

byte *GetTextData(DWORD *len)
{
	DWORD tl=wcslen(text);
	DWORD dl=((tl + 3) & ~0x03)+8;
	char *cText=new char[tl];
	ZeroMemory(cText,tl);

	wcstombs(cText,text,tl);

	byte *out;
	out= new byte[dl];
	ZeroMemory(out,dl);
	memcpy(out, &tl, sizeof(DWORD));

	memcpy(out+4, cText, tl);
	(*len)=dl;

	LEUtilDeleteArray(cText);

	return out;
}

byte *ExportTextData(DWORD *len)
{
	DWORD tl=wcslen(text);
	char *cText=new char[tl];
	ZeroMemory(cText,tl);

	wcstombs(cText,text,tl);

	byte *out;
	out= new byte[tl];
	ZeroMemory(out,tl);
	memcpy(out, cText, tl);
	(*len)=tl;

	LEUtilDeleteArray(cText);

	return out;
}

bool ImportTextData(byte *data,DWORD len)
{
	LEUtilDeleteArray(text);
	textLength=len+LEMAX_STRING;

	text=new TCHAR[textLength];

	char *cText = new char[len];

	memcpy(cText,data,len);

	mbstowcs(text,cText,len);
	text[len]=0;

	LEUtilDeleteArray(cText);

	UpdateTextDialog();

	return true;
}

#endif