#pragma once

#ifndef HV_DOLPHINE_CLASS_DATA_LOADER
#define HV_DOLPHINE_CLASS_DATA_LOADER


#include <common.h>
#include <vector>

#include "loader_export.h"

#include <argument.h>



namespace hv {
	namespace dolphin {
		using smrframe = std::shared_ptr<hv::dolphin::iframe>;
		using smrcLbl = std::shared_ptr<hv::dolphin::icLbl>;
		using batch = std::vector<std::tuple<smrframe, smrcLbl>>;


		class impl_clsDataLoader;
		class clsDataLoader {
		private:
			std::unique_ptr<impl_clsDataLoader> _instance;

		public:

			DOLPHIN_LOADER_API clsDataLoader(std::string path, smrArgument arugment);
			DOLPHIN_LOADER_API ~clsDataLoader();

			DOLPHIN_LOADER_API std::size_t size();
			DOLPHIN_LOADER_API batch operator[](std::size_t index);
			DOLPHIN_LOADER_API void shuffle();
		
		};
	}
}


#endif