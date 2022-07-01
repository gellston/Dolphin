

#include <vector>

#include "macro.h"
#include "exception.h"
#include "frame.h"


namespace hv {
	namespace dolphin {
		class impl_frame {
		public:

			int _width;
			int _height;
			int _channel;
			int _stride;
			hv::dolphin::pixel_type _type;
			size_t _size;
			std::vector<unsigned char> _buffer;

			impl_frame() {
				this->_width = 0;
				this->_height = 0;
				this->_channel = 0;
				this->_stride = 0;
				this->_type = hv::dolphin::pixel_type::non_pixel;
				this->_size = 0;
			}

			~impl_frame() {

			}
		};
	}
}



hv::dolphin::frame::frame(int width, int height, int channel, void* buffer, pixel_type type):
	_instance(new hv::dolphin::impl_frame()){
	

	if (width <= 0 || height <= 0 || channel <= 0 || buffer == nullptr) {
		std::string message = hv::dolphin::generate_error_message(__FUNCTION__, __LINE__, "Invalid image information.");
		throw hv::dolphin::exception(message);
	}


	this->_instance->_width = width;
	this->_instance->_height = height;
	this->_instance->_channel = channel;
	this->_instance->_stride = width * static_cast<int>(type) * channel;
	this->_instance->_size = this->_instance->_stride * this->_instance->_height;
	this->_instance->_buffer.resize(this->_instance->_size);


	std::memcpy(static_cast<void *>(this->_instance->_buffer.data()), buffer, this->_instance->_size);

}

hv::dolphin::frame::frame(int width, int height, int channel, pixel_type type):
	_instance(new hv::dolphin::impl_frame()) {


	if (width <= 0 || height <= 0 || channel <= 0) {
		std::string message = hv::dolphin::generate_error_message(__FUNCTION__, __LINE__, "Invalid image information.");
		throw hv::dolphin::exception(message);
	}


	this->_instance->_width = width;
	this->_instance->_height = height;
	this->_instance->_channel = channel;
	this->_instance->_stride = width * static_cast<int>(type) * channel;
	this->_instance->_size = this->_instance->_stride * this->_instance->_height;
	this->_instance->_buffer.resize(this->_instance->_size);


	std::memset(static_cast<void*>(this->_instance->_buffer.data()), 0, this->_instance->_size);

}

hv::dolphin::frame::~frame() {


}

int hv::dolphin::frame::width() {

	return this->_instance->_width;
}

int hv::dolphin::frame::height() {
	return this->_instance->_height;
}

std::size_t hv::dolphin::frame::size() {
	return this->_instance->_size;
}

void * hv::dolphin::frame::data() {

	return this->_instance->_buffer.data();
}

int hv::dolphin::frame::channel() {
	return this->_instance->_channel;
}

int hv::dolphin::frame::stride() {
	return this->_instance->_stride;
}

hv::dolphin::pixel_type hv::dolphin::frame::type() {
	return hv::dolphin::pixel_type::byte_pixel;
}