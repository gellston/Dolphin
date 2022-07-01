#pragma once

#ifndef HV_DOLPHIN_MACRO
#define HV_DOLPHIN_MACRO


#include <string>


namespace hv {
	namespace dolphin {
		inline std::string generate_error_message(const char* function_name, int line, std::string _context) {
			std::string full_context = "";
			full_context += function_name;
			full_context += ":";
			full_context += std::to_string(line);
			full_context += _context;
			return full_context;
		}

	}
}

#endif