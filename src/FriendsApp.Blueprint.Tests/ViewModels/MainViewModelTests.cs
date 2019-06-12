﻿using System;
using System.Collections.Generic;
using System.Text;
using FriendsApp.Blueprint.ViewModels;
using Xunit;

namespace FriendsApp.Blueprint.Tests.ViewModels
{
    public class MainViewModelTests : TestBase
    {
        private readonly IMainViewModel m_cut;

        [Fact]
        public void AddNewFriendCommand_NewFriendNameIsSet_NewFriendNameIsAdded()
        {
            //Arrange
            m_cut.NewFriendName = "John Doe";

            //Act
            m_cut.AddNewFriendCommand.Execute(null);

            //Assert
            Assert.NotEmpty(m_cut.Friends);
        }

        [Fact]
        public void AddNewFriendCommand_NewFriendNameIsSet_NewFriendNameIsEmpty()
        {
            m_cut.NewFriendName = "John Doe";

            m_cut.AddNewFriendCommand.Execute(null);

            Assert.Equal(m_cut.NewFriendName, string.Empty);
        }
    }
}
