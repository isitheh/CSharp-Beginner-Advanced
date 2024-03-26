using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalculationsTests
{
    public class NamesTests
    {
        [Fact]
        public void GetFullName_ValidFirstAndLastName_FullName()
        {
            var names = new Names();
            var result = names.GetFullName("John", "Doe");
            Assert.Equal("John Doe", result);
        }

        [Fact]
        public void GetFullName_ValidFirstAndLastName_ContainsPartOfName()
        {
            var names = new Names();
            var result = names.GetFullName("John", "Doe");
            Assert.Contains("ohn", result);
        }

        [Fact]
        public void GetFullName_ValidFirstAndLastName_FormatedAsHumanName()
        {
            //Using regex to check if the name is formated as a human name
            var names = new Names();
            var result = names.GetFullName("John", "Doe");
            Assert.Matches("[A-Z]{1}[a-z]+ [A-Z]{1}[a-z]+", result);
        }

        //Create a test that checks if the name is not empty
        [Fact]
        public void GetFullName_ValidFirstAndLastName_NotEmpty()
        {
            var names = new Names();
            var result = names.GetFullName("John", "Doe");
            Assert.NotEmpty(result);
        }

        //Create a test that checks if the NickName prop is not null
        [Fact]          
        public void NickName_NotNull()
        {
            var names = new Names();
            names.NickName = "Mshishi";
            Assert.NotNull(names.NickName);
        }

        //Create a test that checks if the NickName prop is null
        [Fact]
        public void NickName_Null()
        {
            var names = new Names();
            Assert.Null(names.NickName);
        }
    }
}
