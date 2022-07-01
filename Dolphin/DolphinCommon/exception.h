#pragma once


#ifndef HV_DOLPHIN_EXCEPTION
#define HV_DOLPHIN_EXCEPTION


#include <stdexcept>

namespace hv {
	namespace dolphin {

		class exception : public std::runtime_error {
		public:
			exception() : std::runtime_error("") {}
			exception(const std::string& message = "") : std::runtime_error(message){}
		};


		class notimpl_exception : hv::dolphin::exception {
		public:
			notimpl_exception() : hv::dolphin::exception("") {}
			notimpl_exception(const std::string& message = "") : hv::dolphin::exception(message){}
		};



	}
}




#endif