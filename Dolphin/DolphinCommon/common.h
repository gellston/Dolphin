#pragma once


#ifndef HV_COMMON_HELPER
#define HV_COMMON_HELPER


#include <memory>

#include "common_export.h"
#include "argument.h"
#include "iframe.h"
#include "icLbl.h"
#include "macro.h"

namespace hv {
	namespace dolphin {
		class common {
		public:
			DOLPHIN_COMMON_API static std::shared_ptr<hv::dolphin::iframe> frame(int width, int height, int channel, void* buffer, hv::dolphin::pixel_type type);
			DOLPHIN_COMMON_API static std::shared_ptr<hv::dolphin::iframe> frame(int width, int height, int channel, hv::dolphin::pixel_type type);

			DOLPHIN_COMMON_API static std::shared_ptr<icLbl> classLabel(std::vector<float>& labels);
			DOLPHIN_COMMON_API static std::shared_ptr<icLbl> classLabel(std::initializer_list<float> list);
		};
	}
}



#endif