#include "cLbl.h"

namespace hv {
	namespace dolphin {
		class impl_cLbl {
		public:

			std::vector<float> _labels;

			impl_cLbl() {

			}

			~impl_cLbl() {

			}

		};
	}
}

hv::dolphin::cLbl::cLbl(std::vector<float>& labels) : _instance(new hv::dolphin::impl_cLbl()) {
	this->_instance->_labels = labels;
}

hv::dolphin::cLbl::cLbl(std::initializer_list<float> list) : _instance(new hv::dolphin::impl_cLbl()) {
	this->_instance->_labels = list;
}

hv::dolphin::cLbl::~cLbl() {

}
 
std::vector<float> hv::dolphin::cLbl::labels() {
	return this->_instance->_labels;
}

std::size_t hv::dolphin::cLbl::size() {
	return this->_instance->_labels.size();
}