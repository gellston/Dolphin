#pragma once

#ifndef HV_DOLPHIN_ARGUMENT
#define HV_DOLPHIN_ARGUMENT

#include <string>
#include <memory>
#include <variant>
#include <iostream>

#include "common_export.h"
#include "exception.h"

namespace hv {
	namespace dolphin {
		using arg = std::variant<bool, std::string, double, int>;

		class impl_argument;
		class argument {

		public:
			DOLPHIN_COMMON_API argument();
			DOLPHIN_COMMON_API argument(std::initializer_list<std::tuple<std::string, arg>> list);
			DOLPHIN_COMMON_API ~argument();


			template<typename T> T get(std::string key) {}
			template<typename T> T get(const char* key) {
				try {
					return this->get<T>(std::string(key));
				}
				catch (hv::dolphin::exception e) {
					throw e;
				}
			}
			template<> DOLPHIN_COMMON_API double get(std::string key);
			template<> DOLPHIN_COMMON_API int get(std::string key);
			template<> DOLPHIN_COMMON_API std::string get(std::string key);
			template<> DOLPHIN_COMMON_API bool get(std::string key);


			template<typename T> void add(std::string key, T value) {}
			template<typename T> void add(const char* key, T value) {
				try {
					this->add<T>(std::string(key), value);
				}
				catch (hv::dolphin::exception e) {
					throw e;
				}
			}
			template<> DOLPHIN_COMMON_API void add(std::string key, double value);
			template<> DOLPHIN_COMMON_API void add(std::string key, int value);
			template<> DOLPHIN_COMMON_API void add(std::string key, bool value);
			template<> DOLPHIN_COMMON_API void add(std::string key, std::string value);
			template<> DOLPHIN_COMMON_API void add(std::string key, const char * value);

			DOLPHIN_COMMON_API std::string parse();
			DOLPHIN_COMMON_API void print();

		private:
			std::unique_ptr<impl_argument> _instance;
		};

		using smrArgument = std::shared_ptr<argument>;
	}
}

#endif