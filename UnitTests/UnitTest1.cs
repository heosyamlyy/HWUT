using Microsoft.VisualStudio.TestTools.UnitTesting;
using HWUT.Models;
using System;
using System.Collections;
using System.Text.Json;

namespace UnitTests
{
    [TestClass]
    public class ProductModelTests
    {
        [TestMethod]
        public void ProductModel_Constructor_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.IsNotNull(result);
        }

        
        [TestMethod]
        public void ProductModel_Get_Id_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Id = "CPSC";

            // Act
            var result = data.Id;

            // Assert
            Assert.AreEqual("CPSC", result);
        }

        [TestMethod]
        public void ProductModel_Set_Id_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Id = "ID";
            var result = data.Id;

            // Assert
            Assert.AreEqual("ID", result);
        }

        [TestMethod]
        public void ProductModel_Get_Maker_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Maker = "Dell";

            // Act
            var result = data.Maker;

            // Assert
            Assert.AreEqual("Dell", result);
        }

        [TestMethod]
        public void ProductModel_Set_Maker_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Maker = "Microsoft";
            var result = data.Maker;

            // Assert
            Assert.AreEqual("Microsoft", result);
        }


        [TestMethod]
        public void ProductModel_GetSet_Image_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Image = "./image/1.png";
            var result = data.Image;

            // Assert
            Assert.AreEqual("./image/1.png", result);
        }

        [TestMethod]
        public void ProductModel_Get_Url_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Url = "TourStart";

            // Act
            var result = data.Url;

            // Assert
            Assert.AreEqual("TourStart", result);
        }

        [TestMethod]
        public void ProductModel_Set_Url_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Url = "bogus";
            var result = data.Url;

            // Assert
            Assert.AreEqual("bogus", result);
        }

        [TestMethod]
        public void ProductModel_Get_Title_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Title = "Seattle U, a pretty Campus";

            // Act
            var result = data.Title;

            // Assert
            Assert.AreEqual("Seattle U, a pretty Campus", result);
        }

        [TestMethod]
        public void ProductModel_Set_Title_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Title = "Apple Earbuds";
            var result = data.Title;

            // Assert
            Assert.AreEqual("Apple Earbuds", result);
        }

        [TestMethod]
        public void ProductModel_Get_Description_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Description = "Come view the trees and flowers on this campus walk";

            // Act
            var result = data.Description;

            // Assert
            Assert.AreEqual("Come view the trees and flowers on this campus walk", result);
        }

        [TestMethod]
        public void ProductModel_Set_Description_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Description = "Never used, so not gross. I want $$$";
            var result = data.Description;

            // Assert
            Assert.AreEqual("Never used, so not gross. I want $$$", result);
        }


        [TestMethod]
        public void ProductModel_Set_Date_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Date = DateTime.Now;
            var result = data.Date;

            // Assert
            Assert.AreEqual(DateTime.Now.ToShortTimeString(), result.ToShortTimeString());
        }

        [TestMethod]
        public void ProductModel_Get_Date_Default_Should_Pass()
        {
            // Arrange

            // Act
            var result = new ProductModel();

            // Assert
            Assert.AreEqual(DateTime.UtcNow.ToShortDateString(), result.Date.ToShortDateString());
        }

        [TestMethod]
        public void ProductModel_Get_Sequence_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Sequence = "TourStart2";

            // Act
            var result = data.Sequence;

            // Assert
            Assert.AreEqual("TourStart2", result);
        }

        [TestMethod]
        public void ProductModel_Set_Sequence_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Sequence = "TourStart5";
            var result = data.Sequence;

            // Assert
            Assert.AreEqual("TourStart5", result);
        }

        [TestMethod]
        public void ProductModel_Get_Email_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Email = "koenigm@seattleu.edu";

            // Act
            var result = data.Email;

            // Assert
            Assert.AreEqual("koenigm@seattleu.edu", result);
        }

        [TestMethod]
        public void ProductModel_Set_Email_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Email = "yliu2@seattleu.edu";
            var result = data.Email;

            // Assert
            Assert.AreEqual("yliu2@seattleu.edu", result);
        }

               [TestMethod]
        public void ProductModel_Get_Logistics_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            var result = data.Logistics;

            // Assert
            Assert.AreEqual("", result);
        }

        [TestMethod]
        public void ProductModel_Set_Logistics_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            data.Logistics = "I will pickup";
            var result = data.Logistics;

            // Assert
            Assert.AreEqual("I will pickup", result);
        }


        [TestMethod]
        public void ProductModel_GetSet_Rating_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();

            // Act
            System.Collections.Generic.List<int> bufferList = new System.Collections.Generic.List<int>();
            foreach (int i in data.Ratings)
            {
                bufferList.Add(i);
            }
            bufferList.Add(1);

            data.Ratings = bufferList.ToArray();
            var result = data.Ratings;

            // Assert
            Assert.AreEqual(2, result.Length);
            Assert.AreEqual(1, result[1]);
        }

        [TestMethod]
        public void ProductModel_ToString_Default_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            var expected = JsonSerializer.Serialize(data);

            // Act
            var result = data.ToString();

            // Assert
            Assert.AreEqual(expected, result);

        }

        [TestMethod]
        public void ProductModel_AverageRating_Null_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = null;

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void ProductModel_AverageRating_Zero_Count_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[]{ };

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void ProductModel_AverageRating_Zero_Total_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[] {0, 0, 0};

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(3, data.Ratings.Length);
            Assert.AreEqual(0, result);

        }

        [TestMethod]
        public void ProductModel_AverageRating_Else_Should_Pass()
        {
            // Arrange
            var data = new ProductModel();
            data.Ratings = new int[] { 5, 3, 1 };

            // Act
            var result = data.AverageRating();

            // Assert
            Assert.AreEqual(3, data.Ratings.Length);
            Assert.AreEqual(3, result);

        }

    }
}

