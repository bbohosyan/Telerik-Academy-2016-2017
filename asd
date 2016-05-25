
#include <iostream>
#include<cstring>
#include<string.h>

using namespace std;

class Employee {
  public:
	  Employee(char* theName = " ", float thePayRate = 0)
    {
	  name = new char[strlen(theName) + 1];
	  strcpy(name, theName);

	  payRate = thePayRate;
    }
	  Employee(const Employee& other)
    {
	  name = new char[strlen(other.getName()) + 1];
	  strcpy(name, other.getName());

	  payRate = other.getPayRate();
    }
	  Employee& operator=(const Employee& other)
	  {
	  if (this != &other)
	  {
		delete[] name;
		name = new char[strlen(other.getName()) + 1];
		strcpy(name, other.getName());
		payRate = other.getPayRate();
	  }

	  return *this;
    }
	  ~Employee()
	  {
	    delete[] name;
	  }

	  char* getName() const
	  {
	    return name;
	  }
	float getPayRate() const
	{
	    return payRate;
	}

	float pay(float hoursWorked) const
	{
	    return hoursWorked * payRate;
	}

  protected:
	char* name;
	float payRate;
};

class Manager : public Employee {
  public:
	  Manager(char* theName,float thePayRate,bool isSalaried): Employee(theName, thePayRate)
    {
	  salaried = isSalaried;
    }

	  bool getSalaried() const;

	  float pay(float hoursWorked) const
	  {
	  if (salaried)
		return payRate;
	  /* else */
	  return Employee::pay(hoursWorked);
    }

  protected:
	bool salaried;
};

int main()
{
    Manager ivan("asdf",3.45,true);
    return 0;
}
