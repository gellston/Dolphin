#include "clsDataLoader.h"


#include <nlohmann/json.hpp>
#include <opencv2/opencv.hpp>
#include <algorithm>
#include <filesystem>


namespace hv {
	namespace dolphin {
		class impl_clsDataLoader {
		public:
			std::string path;
			smrArgument argument;
			int batchSize;





			impl_clsDataLoader() {
				this->batchSize = 0;
			}

			~impl_clsDataLoader() {

			}
		};
	}
}



hv::dolphin::clsDataLoader::clsDataLoader(std::string path, smrArgument argument) : _instance(new hv::dolphin::impl_clsDataLoader()) {

	this->_instance->path = path;
	this->_instance->argument = argument;

	try {
		

		this->_instance->batchSize = argument->get<int>("batchSize");



		if (this->_instance->batchSize < 0) {
			throw std::exception("Invalid batch size");
		}
			


		if (std::filesystem::exists(path) == false) {
			throw std::exception("Invalid file path");
		}


	}
	catch (std::exception e) {
		std::string message = dolphin::generate_error_message(__FUNCTION__, __LINE__, e.what());
		throw dolphin::exception(message);
	}

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








