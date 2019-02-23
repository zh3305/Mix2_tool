// Global.h
// Created by Kyle N. Lane
// Date : 1/1/10

#ifndef _UNICODE
#define _UNICODE
#endif

#define _CRT_SECURE_NO_WARNINGS

#ifndef _GLOBAL_H_
#define _GLOBAL_H_

#include "windows.h"
#include "stdio.h"
#include "io.h"
#include "commctrl.h"
#include "Shlobj.h"

#define LEMAX_NAME				64
#define LEMAX_PATH				256
#define LEMAX_STRING			2048

#define LEUtilDeleteArray(p) { if(p!=NULL) { delete[] (p);   (p)=NULL; } }

#endif