namespace FatCat.Tests.LogReader;

public class PlaceHolderTests
{
	[Fact]
	public void SomePlaceHolderTest()
	{
		var item1 = Faker.RandomInt();

		var item2 = Faker.RandomInt();

		item1.Should().Not.Be(item2);
	}
}
