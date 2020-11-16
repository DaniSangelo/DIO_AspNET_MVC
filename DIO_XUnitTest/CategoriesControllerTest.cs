﻿using DIO_API.Controllers;
using DIO_AspNETMVC.Models;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.Linq;

namespace DIO_XUnitTest
{
    public class CategoriesControllerTest
    {
        private readonly Mock<DbSet<Category>> _mockSet;
        private readonly Mock<Context> _mockContext;
        private readonly Category _category;

        public CategoriesControllerTest()
        {
            _mockSet = new Mock<DbSet<Category>>();
            _mockContext = new Mock<Context>();
            _category = new Category { Id = 1, Name = "Category test"};

            _mockContext.Setup(m => m.Categories).Returns(_mockSet.Object);
            _mockContext.Setup(m => m.Categories.FindAsync(1)).ReturnsAsync(_category);
        }

        [Fact]
        public async Task GetCategory()
        {
            var service = new CategoriesController(_mockContext.Object);
            await service.GetCategory(1);
            _mockSet.Verify(m => m.FindAsync(1), Times.Once());
        }
    }
}
