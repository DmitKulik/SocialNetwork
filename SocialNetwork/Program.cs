﻿using SocialNetwork.BLL.Models;
using SocialNetwork.BLL.Services;
using SocialNetwork.BLL.Exceptions;
using SocialNetwork.DAL.Entities;
using SocialNetwork.DAL.Repositories;
using SocialNetwork.PLL.Views;
using SocialNetwork.PLL.Helpers;
using System;

namespace SocialNetwork
{
    class Program
    {
        static MessageService messageService;
        static UserService userService;
        public static MainView mainView;
        public static RegistrationView registrationView;
        public static AuthenticationView authenticationView;
        public static UserMenuView userMenuView;
        public static UserInfoView userInfoView;
        public static UserDataUpdateView userDataUpdateView;
        public static MessageSendingView messageSendingView;
        public static UserIncomingMessageView userIncomingMessageView;
        public static UserOutcomingMessageView userOutcomingMessageView;
        public static UserFriendView userFriendView;
        public static UserAddFriendView userAddFriendView;

        static void Main(string[] args)
        {
            userService = new UserService();
            messageService = new MessageService();

            mainView = new MainView();
            registrationView = new RegistrationView(userService);
            authenticationView = new AuthenticationView(userService);
            userMenuView = new UserMenuView(userService);
            userInfoView = new UserInfoView();
            userDataUpdateView = new UserDataUpdateView(userService);
            messageSendingView = new MessageSendingView(messageService, userService);
            userIncomingMessageView = new UserIncomingMessageView();
            userOutcomingMessageView = new UserOutcomingMessageView();
            userFriendView = new UserFriendView();
            userAddFriendView = new UserAddFriendView(userService);

            while (true)
            {
                mainView.Show();
            }

        }
    }
}