#include "UserAccount.h"
#include <stdlib.h>
#include<string>
#include<iostream>
#include<fstream>
#include<cctype>
#include<iomanip>
#include <map>
#include <vector>
#include <algorithm>
#include "globalVariables.h"

using namespace std;

UserAccount::UserAccount(void)
{
}


UserAccount::~UserAccount(void)
{
}

void UserAccount::create_account()
{
	
    ID++;
    Id=ID;
    cout<<"\nUserAccount No. is :" << Id;
	cout<<"\n\nEnter The Name of The UserAccount Holder : ";
    cin>>name;
	cout<<"\nEnter Type of The UserAccount (C/S) : ";
	cin>>type;
	transform(type.begin(), type.end(), type.begin(), ::toupper);
	cout<<"\nEnter The Initial amount(>=500 for Saving and >=1000 for current ) : ";
	cin>>deposit;
	cout<<"\n\n\nUserAccount Created..";
}

void UserAccount::show_account() const
{
	cout<<"\nUserAccount No. : "<<Id;
	cout<<"\nUserAccount Holder Name : ";
	cout<<name;
	cout<<"\nType of UserAccount : "<<type;
	cout<<"\nBalance amount : "<<deposit;
}


void UserAccount::modify(){
	cout<<"\nUserAccount No. : "<<Id;
	cout<<"\nModify UserAccount Holder Name : ";
	cin>>name;
	cout<<"\nModify Type of UserAccount : ";
	cin>>type;
	transform(type.begin(), type.end(), type.begin(), ::toupper);
	cout<<"\nModify Balance amount : ";
	cin>>deposit;
}


void UserAccount::dep(int x){
	deposit+=x;
}

void UserAccount::draw(int x){
	deposit-=x;
}

void UserAccount::report() const{
	cout<<Id<<setw(9)<<" "<<name<<setw(8)<<" "<<type<<setw(4)<<" "<<deposit<<endl;
}


int UserAccount::retId() const{
	return Id;
}

long UserAccount::retdeposit() const{
	return deposit;
}

string UserAccount::retname() const{
	return name;
}

string UserAccount::rettype() const{
	return type;
}


