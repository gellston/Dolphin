

#include "common.h"


#include "frame.h"
#include "cLbl.h"


std::shared_ptr<hv::dolphin::iframe> hv::dolphin::common::frame(int width, int height, int channel, void* buffer, hv::dolphin::pixel_type type) {

	std::shared_ptr<hv::dolphin::iframe> _frame(new hv::dolphin::frame(width, height, channel, buffer, type));

	return _frame;
}

std::shared_ptr<hv::dolphin::iframe> hv::dolphin::common::frame(int width, int height, int channel, hv::dolphin::pixel_type type) {

	std::shared_ptr<hv::dolphin::iframe> _frame(new hv::dolphin::frame(width, height, channel, type));

	return _frame;
}


std::shared_ptr<hv::dolphin::icLbl> hv::dolphin::common::classLabel(std::vector<float>& labels) {

	std::shared_ptr<hv::dolphin::icLbl> _classLabel(new hv::dolphin::cLbl(labels));

	return _classLabel;
}

std::shared_ptr<hv::dolphin::icLbl> hv::dolphin::common::classLabel(std::initializer_list<float> list) {
	std::shared_ptr<hv::dolphin::icLbl> _classLabel(new hv::dolphin::cLbl(list));

	return _classLabel;
}