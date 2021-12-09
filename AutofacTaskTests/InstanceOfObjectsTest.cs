using Autofac;
using AutofacTask;
using Contract.Infrastructures;
using Contract.Managers;
using Contract.Repositories;
using Contract.Services;
using NUnit.Framework;
using System.Collections.Generic;
using System.Linq;

namespace AutofacTaskTests
{
  public class InstanceOfObjectsTest
  {
    private IContainer container;

    [SetUp]
    public void Setup()
    {
      this.container = new MyContainer().Container;
    }

    [Test]
    public void Configuration_ShouldBeSingleton()
    {
      // Arrange
      IConfiguration config1;
      IConfiguration config2;

      // Act
      config1 = this.container.Resolve<IConfiguration>();
      config2 = this.container.Resolve<IConfiguration>();

      // Assert
      Assert.IsTrue(object.ReferenceEquals(config1, config2));
    }

    [Test]
    public void ClientManager_ShouldBeTheSameInstance()
    {
      // Arrange
      IClientManager clientManager1;
      IClientManager clientManager2;

      // Act
      clientManager1 = this.container.Resolve<IClientManager>();
      clientManager2 = this.container.Resolve<IClientManager>();

      // Assert
      Assert.IsTrue(object.ReferenceEquals(clientManager1, clientManager2));
    }

    [Test]
    public void Repositories_ShouldBeTheSameInstance()
    {
      // Arrange
      IClientRepository clientRepository1;
      IClientRepository clientRepository2;

      // Act
      clientRepository1 = this.container.Resolve<IClientRepository>();
      clientRepository2 = this.container.Resolve<IClientRepository>();

      // Assert
      Assert.IsTrue(object.ReferenceEquals(clientRepository1, clientRepository2));
    }

    [Test]
    public void Configuration_ShouldBeSingletonForAllScopes()
    {
      // Arrange
      IConfiguration config1;
      IConfiguration config2;

      // Act
      config1 = this.container.Resolve<IConfiguration>();

      using (var scope1 = this.container.BeginLifetimeScope())
      {
        config2 = scope1.Resolve<IConfiguration>();
      }

      // Assert
      Assert.IsTrue(object.ReferenceEquals(config1, config2));
    }

    [Test]
    public void ClientManager_ShouldBeDifferentInstanceWithOnDifferentScope()
    {
      // Arrange
      IClientManager clientManager1;
      IClientManager clientManager2;
      IClientManager clientManager3;

      // Act
      clientManager1 = this.container.Resolve<IClientManager>();
      
      using(var scope = this.container.BeginLifetimeScope())
      {
        clientManager2 = scope.Resolve<IClientManager>();

        using (var scope2 = scope.BeginLifetimeScope())
        {
          clientManager3 = scope2.Resolve<IClientManager>();
        }
      }

      // Assert
      Assert.IsFalse(object.ReferenceEquals(clientManager1, clientManager2));
      Assert.IsFalse(object.ReferenceEquals(clientManager2, clientManager3));
    }

    [Test]
    public void ImplementationOfClientRepository_ShouldBeNumberOfTwo()
    {
      // Arrange
      IEnumerable<IClientRepository> clientRepository;

      // Act
      clientRepository = this.container.Resolve<IEnumerable<IClientRepository>>();

      // Assert
      Assert.AreEqual(clientRepository.Count(), 2);
    }

    [Test]
    public void ActiveClientRepository_ShouldBeNotNull()
    {
      // Arrange
      IClientRepository clientRepository;

      // Act
      clientRepository = this.container.ResolveNamed<IClientRepository>("ActiveClientRepository");

      // Assert
      Assert.IsTrue(clientRepository != null);
      Assert.AreEqual(clientRepository.GetType().Name, "ActiveClientRepository");
    }

    [Test]
    public void DevUserService_ShouldBeNotNull()
    {
      // Arrange
      IUserService userService;

      // Act
      userService = this.container.Resolve<IUserService>();

      // Assert
      Assert.IsTrue(userService != null);
      Assert.AreEqual(userService.GetType().Name, "DevUserService");
    }

    [Test]
    public void ProdUserService_ShouldBeNotNull()
    {
      // Arrange
      IUserService userService;
      IConfiguration configuration;

      // Act
      configuration = this.container.Resolve<IConfiguration>();
      configuration.IsProductionMode = true;

      userService = this.container.Resolve<IUserService>();

      configuration.IsProductionMode = false;

      // Assert
      Assert.IsTrue(userService != null);
      Assert.AreEqual(userService.GetType().Name, "ProdUserService");
    }

  }
}