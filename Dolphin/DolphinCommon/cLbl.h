#pragma once

#ifndef HV_DOLPHIN_CLASS_LABEL
#define HV_DOLPHIN_CLASS_LABEL

#include <memory>

#include "icLbl.h"

namespace hv {
	namespace dolphin {
		class impl_cLbl;
		class cLbl : public icLbl {
		private:
			std::unique_ptr<impl_cLbl> _instance;
		public:
			cLbl() = delete;
			cLbl& operator=(const cLbl&) = delete;
			virtual ~cLbl() override;
			explicit cLbl(std::vector<float>& labels);
			explicit cLbl(std::initializer_list<float> list);
			std::vector<float> labels() override;
			std::size_t size() override;
		};
	}
}

#endif