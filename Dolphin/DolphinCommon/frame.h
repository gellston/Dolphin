#pragma once

#ifndef HV_DOLPHIN_FRAME
#define HV_DOLPHIN_FRAME

#include <memory>

#include "iframe.h"

namespace hv {
	namespace dolphin {
		class impl_frame;
		class frame : public iframe {
		private:
			std::unique_ptr<impl_frame> _instance;

		public:
			frame() = delete;
			frame& operator=(const frame&) = delete;
			frame(int width, int height, int channel, void* buffer, pixel_type type);
			frame(int width, int height, int channel, pixel_type type);
			virtual ~frame() override;
			void* data() override;
			int stride() override;
			int width() override;
			int height() override;
			int channel() override;
			std::size_t size() override;
			pixel_type type() override;
		};
	}
}

#endif