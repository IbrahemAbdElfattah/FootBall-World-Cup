//***************************************************************
//                   HEADER FILE USED IN PROJECT
//****************************************************************
#include <stdlib.h>
#include<string>
#include<iostream>
#include<fstream>
#include<cctype>
#include<iomanip>
#include <map>
#include <vector>
#include <algorithm>
#include "UserAccount.h"


using namespace std;

std::vector<int> x;


//std::map<int,account> AllData;

//***************************************************************
//                   CLASS USED IN PROJECT
//***************************************************************



//***************************************************************
//    	Map declaration
//****************************************************************

std::map<int,class UserAccount> userAccount;

/*---------
pop map and id from file
***********/
std::map<int,class UserAccount>::iterator IT;


//***************************************************************
//    	function declaration
//****************************************************************
void write_account();	//function to write record in binary file
void display_sp(int);	//function to display account details given by user
void modify_account(int);	//function to modify record of file
void delete_account(int);	//function to delete record of file
void display_all();		//function to display all account details
void deposit_withdraw(int, int); // function to desposit/withdraw amount for given account
void intro();	//introductory screen function

//***************************************************************
//    	THE MAIN FUNCTION OF PROGRAM
//****************************************************************


int main()
{
	int ch;
	int num;
	intro();
	do
	{
		system("cls");
		cout<<"\n\n\n\tMAIN MENU";
		cout<<"\n\n\t01. NEW ACCOUNT";
		cout<<"\n\n\t02. DEPOSIT AMOUNT";
		cout<<"\n\n\t03. WITHDRAW AMOUNT";
		cout<<"\n\n\t04. BALANCE ENQUIRY";
		cout<<"\n\n\t05. ALL ACCOUNT HOLDER LIST";
		cout<<"\n\n\t06. CLOSE AN ACCOUNT";
		cout<<"\n\n\t07. MODIFY AN ACCOUNT";
		cout<<"\n\n\t08. EXIT";
		cout<<"\n\n\tSelect Your Option (1-8) ";
		cin>>ch;
		system("cls");
		switch(ch)
		{
		case 1:
			write_account();
			break;
		case 2:
			cout<<"\n\n\tEnter The account No. : "; cin>>num;
			deposit_withdraw(num, 1);
			break;
		case 3:
			cout<<"\n\n\tEnter The account No. : "; cin>>num;
			deposit_withdraw(num, 2);
			break;
		case 4:
			cout<<"\n\n\tEnter The account No. : "; cin>>num;
			display_sp(num);
			break;
		case 5:
			display_all();
			break;
		case 6:
			cout<<"\n\n\tEnter The account No. : "; cin>>num;
			delete_account(num);
			break;
		 case 7:
			cout<<"\n\n\tEnter The account No. : "; cin>>num;
			modify_account(num);
			break;
		 case 8:
			cout<<"\n\n\tThanks for using AIS bank management system";
			break;
		 default :cout<<"\a";
		}
		cin.ignore();
		cin.get();
	}while(ch!=8);
	return 0;
}


//***************************************************************
//    	function to write in file
//****************************************************************

void write_account()
{
	UserAccount ac;
	ac.create_account();
    userAccount[ac.retId()]=ac;
}

//***************************************************************
//    	function to read specific record from file
//****************************************************************

void display_sp(int n)
{
	UserAccount ac;
	bool flag=false;


    if(userAccount.empty()!=true)
    {
        cout<<"\nAccount DETAILS\n";

		    ac=userAccount[n];
		    ac.show_account();
            flag=true;

	if(flag==false)
		{cout<<"\n\nAccount number does not exist";}
    }else
    {
        cout<<"\nAccount List is empty\n";
    }
}


//***************************************************************
//    	function to modify record of file
//****************************************************************

void modify_account(int n)
{

	UserAccount ac;
    if(userAccount.empty()!=true)
    {
    for (IT=userAccount.begin(); IT!=userAccount.end(); IT++)
    {
        if(IT->first==n)
        {
            display_sp(n);
            ac=userAccount[n];
            cout<<"\n\nEnter The New Details of account"<<endl;
            ac.modify();
            userAccount[n]=ac;
           	cout<<"\n\n\t Record Updated";
            break;
        }else
        {
            		cout<<"\n\n Account Number Not Found ";
        }
    }
    }else
        {
            cout<<"\nAccount List is empty\n";
        }
}

//***************************************************************
//    	function to delete record of file
//****************************************************************


void delete_account(int n)
{
	if(userAccount.empty()!=true)
    {
    userAccount.erase(n);
    cout<<"\n\n\tRecord Deleted ..";
    }else
    {
        cout<<"\nAccount List is empty\n";
    }
}

//***************************************************************
//    	function to display all accounts deposit list
//****************************************************************

void display_all()
{
	UserAccount ac;

	cout<<"\n\n\t\tACCOUNT HOLDER LIST\n\n";
	cout<<"====================================================\n";
	cout<<"A/c no.      NAME           Type  Balance\n";
	cout<<"====================================================\n";

	if(userAccount.empty()!=true)
    {
        for(IT=userAccount.begin();IT!=userAccount.end();IT++)
        {
            ac=userAccount[IT->first];
            ac.report();
        }

    }else
    {
        cout<<"\nAccount List is empty\n";
    }
}

//***************************************************************
//    	function to deposit and withdraw amounts
//****************************************************************

void deposit_withdraw(int n, int option)
{
	int amt;
	bool found=false;
	UserAccount ac;
    if(userAccount.empty()!=true)
    {
        for (IT=userAccount.begin(); IT!=userAccount.end(); IT++)
        {

            if(IT->first==n)
            {
            found=true;
            ac=userAccount[n];
            ac.show_account();

                if(option==1)
                {
				cout<<"\n\n\tTO DEPOSITE AMOUNT ";
				cout<<"\n\nEnter The amount to be deposited: ";
				cin>>amt;
				ac.dep(amt);
				userAccount[n]=ac;
                }
                if(option==2)
                {
				cout<<"\n\n\tTO WITHDRAW AMOUNT ";
				cout<<"\n\nEnter The amount to be withdraw: ";
				cin>>amt;
				int bal=ac.retdeposit()-amt;
				if((bal<500 && ac.rettype()=="S") || (bal<1000 && ac.rettype()=="C"))
					{cout<<"Insufficience balance";}
				else
                {
					ac.draw(amt);
					userAccount[n]=ac;
                }
                }
			cout<<"\n\n\t Record Updated";
            }
            else if(found=false)
                cout<<"\n\n Account Number Not Found ";

        }
    }else
     {
        cout<<"\nAccount List is empty\n";
     }
}


//***************************************************************
//    	INTRODUCTION FUNCTION
//****************************************************************


void intro()
{
	cout<<"\n\n\n\t  AIS Bank";
	cout<<"\n\n\tManagement";
	cout<<"\n\n\t  System";
	cin.get();
}

/*
push map and id to file
*/


//***************************************************************
//    			END OF PROJECT
//***************************************************************
