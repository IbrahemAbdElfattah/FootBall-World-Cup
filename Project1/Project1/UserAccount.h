#pragma once

#include<string>
#include<iostream>
#include<fstream>
#include<cctype>
#include<iomanip>
#include <map>
#include <vector>
#include <algorithm>
using namespace std;



class UserAccount
{
	int Id;
	string name;
	long deposit;
	string type;

public:
	UserAccount(void);
	~UserAccount(void);
	void create_account();	//function to get data from user
	void show_account() const;	//function to show data on screen
	void modify();	//function to add new data
	void dep(int);	//function to accept amount and add to balance amount
	void draw(int);	//function to accept amount and subtract from balance amount
	void report() const;	//function to show data in tabular format
	int retId() const;	//function to return account number
	long retdeposit() const;	//function to return balance amount
	string rettype() const; //function to return type of account
	string retname() const; //function to return name of account
};

