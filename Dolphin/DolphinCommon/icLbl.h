#pragma once
#ifndef HV_DOLPHIN_ICLASS_LABEL
#define HV_DOLPHIN_ICLASS_LABEL

#include <vector>

namespace hv {
	namespace dolphin {

		class icLbl {
		public:
			virtual ~icLbl() { };
			virtual std::size_t size() = 0;
			virtual std::vector<float> labels() = 0;
		};
	}
}

#endif