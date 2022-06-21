using AutoMapper;
using Moq;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TodoWebApi.Mappings;
using TodoWebApi.Models;
using TodoWebApi.Respositories;
using TodoWebApi.Services;

namespace TodoWebApi.UnitTests.Services
{
    [TestFixture]
    public class TodoItemServiceTests
    {
        [Test]
        public async Task Test()
        {
            // Arrange
            var config = new MapperConfiguration(cfg => cfg.AddProfile<MappingProfile>());
            var mapper = config.CreateMapper();

            var todoItemRepository = new Mock<ITodoItemRepository>();
            todoItemRepository
                .Setup(x => x.GetByIdAsync(It.IsAny<int>()))
                .ReturnsAsync(new TodoItem()
                {
                    Id = 1,
                    Price = 1.0M
                });

            var todoItemService = new TodoItemService(todoItemRepository.Object, mapper);

            // Act
            var todoItem = await todoItemService.GetByIdWithDiscount(1);

            // Assert
            Assert.AreEqual(0.9, todoItem.Price);


        }
    }
}
