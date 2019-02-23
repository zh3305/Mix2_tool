///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
//
//
//   This is the main file with everything needed for every plugin.  The other files are only a demonstration of a simple plugin.
//   Every plugin must contain these exported functions to work with the editor.
//
//
///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
#include "resource.h"
#include "Global.h"
#include "Dialogs/Text.h"

HINSTANCE hDll;
 
#ifdef __cplusplus    // If used by C++ code, 
extern "C" {          // we need to export the C interface
#endif

int _afxForceUSRDLL;
 
// This function is called when the user selects an asset that has been registered to your plugin.  The function delivers to you a pointer to an array of bytes
// that contains the selected assets data.  It also sends a DWORD containing the size in bytes of the data.  Every plugin should create some kind of child window of the mainhWnd,
// and return the handle to the calling program.  The window will be resized by the calling program, so you should make sure any controls in your window get
// resized when the recieve a WM_SIZE message.
__declspec(dllexport) HWND __cdecl CreatePluginDialog(HWND mainhWnd,byte *data,DWORD dataSize)
{
    return CreateTextDialog(hDll,mainhWnd,data,dataSize);
}

// The function is called when the calling application needs to know if it should update the asset.  Usually only called when the user selects a new asset.  If you
// return true, the calling application will call GetData to retrieve the updated data.
__declspec(dllexport) bool __cdecl AssetChanged()
{
    return hasChanged;
}

// This function is called by the calling application to update the data in the asset package.  You should return a dynamically allocated byte array, with the data formatted
// to match the original raw data.  Do not free this array, the calling applicaion will free it when it's finished with the data.  For this reason you should never pass
// any data that you intend to use later.  The len pointer is an out variable that should be filled with the size in bytes of the data array.
__declspec(dllexport) byte* __cdecl GetData(DWORD *len)
{
	byte *out=GetTextData(len);
    return out;
}

// ImportData is called when the calling application has recieved an instruction from the user to import one of your plugins registered file types.  It gives you a byte array
// of the newly imported data, the length of the data, and the extension.  Your plugin should convert the data to the original format, and return a dynamically
// allocated array of bytes to return to the calling application.  Do not free this array, the calling applicaion will free it when it's finished with the data.  For this reason you should never pass
// any data that you intend to use later.  You should also set the len variable to the size of the new data.
__declspec(dllexport) byte* __cdecl ImportData(byte *data,DWORD *len,TCHAR *extension)
{
	ImportTextData(data,(*len));
	byte *out=GetTextData(len);
    return out;
}

// ExportData is called when the user chooses to export an asset to one of your registered file types.  You should create a dynamically allocated byte array, and fill it with
// data formatted for the export type.  Do not free this array, the calling applicaion will free it when it's finished with the data.  For this reason you should never pass
// any data that you intend to use later. You should set the len variable to the size in bytes of the data
// array.
__declspec(dllexport) byte* __cdecl ExportData(DWORD *len,TCHAR *extension)
{
	byte *out=ExportTextData(len);
    return out;
}

// Not required, but I needed to catch the Instance of the module for my dialog box.  You'll probably need it for your window too.
BOOL APIENTRY DllMain( HANDLE hModule, DWORD ul_reason_for_call, LPVOID)
{	 
   switch (ul_reason_for_call) {
      case DLL_PROCESS_ATTACH:
         hDll = (HINSTANCE)hModule;
   }
   return TRUE;
}
 
#ifdef __cplusplus
}
#endif
