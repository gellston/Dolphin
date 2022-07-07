
#include <iostream>


#include <argument.h>



int main()
{

    hv::dolphin::argument arg;

    arg.add("test", 5);

    arg.add("test2", false);


    arg.add("value", 52.2);

    arg.add("test", "there is no cow level");


    arg.print();

    std::cout << arg.parse() << std::endl;


    std::cout << arg.get<std::string>("test") << std::endl;
}
