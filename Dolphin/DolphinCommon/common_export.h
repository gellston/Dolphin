#pragma once



#ifndef DOLPHIN_COMMON_EXPORT
#define DOLPHIN_COMMON_API __declspec(dllimport) 
#define DOLPHIN_COMMON_API_TEMPLATE extern
#else
#define DOLPHIN_COMMON_API __declspec(dllexport)
#define DOLPHIN_COMMON_API_TEMPLATE
#endif