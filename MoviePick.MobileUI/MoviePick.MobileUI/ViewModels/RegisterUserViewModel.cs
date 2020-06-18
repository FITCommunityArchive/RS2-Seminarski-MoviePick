﻿using eProdaja.Mobile;
using MoviePick.Data.Request;
using MoviePick.MobileUI.Views;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace MoviePick.MobileUI.ViewModels
{
    public class RegisterUserViewModel : BaseViewModel
    {
        private readonly APIService _serviceUser = new APIService("User");

        public RegisterUserViewModel()
        {
            RegisterCommand = new Command(async () => await Register());
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string PasswordConfirm { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }

        public ICommand RegisterCommand { get; set; }

        async Task Register()
        {
            try
            {
                if(string.IsNullOrWhiteSpace(FirstName) || string.IsNullOrWhiteSpace(LastName) ||
                    string.IsNullOrWhiteSpace(Email) || string.IsNullOrWhiteSpace(Phone)
                    || string.IsNullOrWhiteSpace(Username) || string.IsNullOrWhiteSpace(Password) || string.IsNullOrWhiteSpace(PasswordConfirm))
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "All fields are required.", "Try again");
                    return;
                }
                if (Password != PasswordConfirm)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Passwords are not matched.", "Try again");
                    return;
                }
                if (Password.Length < 4 || Username.Length < 4)
                {
                    await Application.Current.MainPage.DisplayAlert("Error", "Username & Password must have minimum 4 characthers.", "Try again");
                    return;
                }
                var listUsers = await _serviceUser.Get<List<Data.Model.User>>(null);
                foreach (var item in listUsers)
                {
                    if (Username == item.Username)
                    {
                        await Application.Current.MainPage.DisplayAlert("Error", "Username already exist.", "Try again");
                        return;
                    }
                }
                await _serviceUser.Insert<Data.Model.User>(new UserUpsertRequest
                {
                    FirstName = FirstName,
                    LastName = LastName,
                    Email = Email,
                    Phone = Phone,
                    Password = Password,
                    PasswordConfirm = PasswordConfirm,
                    Username = Username,
                    UserTypeId = 2
                });

                await Application.Current.MainPage.DisplayAlert("Registred succesfully.", "Now just log in.", "OK");
                await Application.Current.MainPage.Navigation.PushModalAsync(new LoginPage());
            }
            catch (Exception ex)
            {
                await Application.Current.MainPage.DisplayAlert("Error", "Wrong input", "Try again");
            }
        }
    }
}