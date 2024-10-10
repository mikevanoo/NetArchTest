using NetArchTest.Rules;
using NetArchTest.SampleLibrary.Data;

namespace NetArchTest.MvOSamples;

public class MvOSampleTests
{
    [Fact]
    public void PresentationShouldNotReferenceData()
    {
        var result = Types.InCurrentDomain()
            .That()
            .ResideInNamespace("NetArchTest.SampleLibrary.Presentation")
            .ShouldNot()
            .HaveDependencyOn("NetArchTest.SampleLibrary.Data")
            .GetResult();
        
        Assert.True(result.IsSuccessful);
    }
    
    [Fact]
    public void ServiceNamesShouldEndWithService()
    {
        var result = Types.InCurrentDomain()
            .That()
            .ResideInNamespace("NetArchTest.SampleLibrary.Services")
            .Should()
            .HaveNameEndingWith("Service")
            .GetResult();
        
        Assert.True(result.IsSuccessful);
    }
    
    [Fact]
    public void RepositoriesShouldResideInData()
    {
        var result = Types.InCurrentDomain()
            .That()
            .HaveNameEndingWith("Repository")
            .Should()
            .ResideInNamespaceEndingWith("Data")
            .GetResult();
        
        Assert.True(result.IsSuccessful);
    }
    
    [Fact]
    public void RepositoriesShouldImplementRepositoryInterface()
    {
        var result = Types.InCurrentDomain()
            .That()
            .HaveNameEndingWith("Repository")
            .And().AreClasses()
            .Should()
            .ImplementInterface(typeof(IRepository<>))
            .GetResult();
        
        Assert.True(result.IsSuccessful);
    }
}