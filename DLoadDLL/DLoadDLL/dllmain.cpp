// dllmain.cpp : Defines the entry point for the DLL application.
#include "stdafx.h"

/*
Notice, to be able to load this DLL in C# application,
you cannot use here specific libraries, for example
you cannot use MessageBox function,
you cannot use shlwapi.dll functions, etc, etc.
For this you can thank C# lang coz it is has so fucking
brilliant dependencies resolving system.
*/

BOOL APIENTRY DllMain( HMODULE hModule,
                       DWORD  ul_reason_for_call,
                       LPVOID lpReserved
					 ) 
{
	switch (ul_reason_for_call)
	{
	case DLL_PROCESS_ATTACH:
	case DLL_THREAD_ATTACH:
	case DLL_THREAD_DETACH:
	case DLL_PROCESS_DETACH:
		break;
	}
	return TRUE;
}

