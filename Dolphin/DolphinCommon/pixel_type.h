#pragma once

#ifndef HV_DOLPHIN_PIXEL_TYPE
#define HV_DOLPHIN_PIXEL_TYPE

namespace hv {
	namespace dolphin {
		enum class pixel_type {
			non_pixel = 0,
			byte_pixel = 1,
			float_pixel = 4,
			double_pixel = 8,
		};
	}
}

#endif