#pragma once

#ifndef HV_DOLPHIN_ARGUMENT
#define HV_DOLPHIN_ARGUMENT

#include <string>
#include <memory>
#include <variant>

#include "common_export.h"

namespace hv {
	namespace dolphin {
		using arg = std::variant<bool, std::string, double, int>;
		class impl_argument;
		class argument {

		public:
			DOLPHIN_COMMON_API argument();
			DOLPHIN_COMMON_API argument(std::initializer_list<std::tuple<std::string, arg>> list);
			DOLPHIN_COMMON_API ~argument();

			template<typename T> T operator[](std::string key) {};
			template<> DOLPHIN_COMMON_API double operator[](std::string key);
			template<> DOLPHIN_COMMON_API std::string operator[](std::string key);
			template<> DOLPHIN_COMMON_API bool operator[](std::string key);
			template<> DOLPHIN_COMMON_API int operator[](std::string key);

			DOLPHIN_COMMON_API std::string parse();
			DOLPHIN_COMMON_API void print();

		private:
			std::unique_ptr<impl_argument> _instance;
		};

		using smrArgument = std::shared_ptr<argument>;
	}
}

#endif