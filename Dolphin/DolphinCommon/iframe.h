#pragma once

#ifndef HV_DOLPHIN_IFRAME
#define HV_DOLPHIN_IFRAME

#include "pixel_type.h"

namespace hv {
	namespace dolphin {

		class iframe {
		public:
			virtual ~iframe(){ };
			virtual void* data() = 0;
			virtual int stride() = 0;
			virtual int width() = 0;
			virtual int height() = 0;
			virtual int channel() = 0;
			virtual std::size_t size() = 0;
			virtual pixel_type type() = 0;
		};
	}
}

#endif