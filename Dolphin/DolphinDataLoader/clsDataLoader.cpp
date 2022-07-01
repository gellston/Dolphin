#include "clsDataLoader.h"



namespace hv {
	namespace dolphin {
		class impl_clsDataLoader {
		public:
			std::string path;
			smrArgument argument;
			impl_clsDataLoader() {

			}

			~impl_clsDataLoader() {

			}
		};
	}
}



hv::dolphin::clsDataLoader::clsDataLoader(std::string path, smrArgument argument) : _instance(new hv::dolphin::impl_clsDataLoader()) {

	this->_instance->path = path;
	this->_instance->argument = argument;

}

hv::dolphin::clsDataLoader::~clsDataLoader() {


}

std::size_t hv::dolphin::clsDataLoader::size() {


	return 0;
}

hv::dolphin::batch hv::dolphin::clsDataLoader::operator[](std::size_t index) {
	batch test;
	return test;
}

void hv::dolphin::clsDataLoader::shuffle() {

}








