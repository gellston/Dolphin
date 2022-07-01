#pragma once



#ifndef DOLPHIN_LOADER_EXPORT
#define DOLPHIN_LOADER_API __declspec(dllimport) 
#define DOLPHIN_LOADER_API_TEMPLATE extern
#else
#define DOLPHIN_LOADER_API __declspec(dllexport)
#define DOLPHIN_LOADER_API_TEMPLATE
#endif