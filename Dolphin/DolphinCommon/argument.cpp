


#include "argument.h"



#include <map>


namespace hv {
	namespace dolphin {

		class impl_argument {
		public:

			std::map<std::string, arg> table;

			impl_argument() {

			}
			~impl_argument() {

			}


		};
	}
}





hv::dolphin::argument::argument() : _instance(new hv::dolphin::impl_argument()) {
	
}

hv::dolphin::argument::argument(std::initializer_list<std::tuple<std::string, arg>> list) : _instance(new hv::dolphin::impl_argument()) {




}

hv::dolphin::argument::~argument() {

}

template<> double hv::dolphin::argument::operator[](std::string key) {


	return 0;
}

template<> int hv::dolphin::argument::operator[](std::string key) {


	return 0;
}

template<> std::string hv::dolphin::argument::operator[](std::string key) {


	return "";
}

template<> bool hv::dolphin::argument::operator[](std::string key) {


	return false;
}

std::string hv::dolphin::argument::parse() {

	return "";
}

void hv::dolphin::argument::print() {

}