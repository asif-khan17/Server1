using Moq;
using System.Collections.Generic;
using System.Linq;
using Xunit;

namespace InventoryUnitTesting
{
    public class Testing
    {
        private readonly IList<Product> _productList;
        private readonly IList<Cart> _cartList;
        private readonly IList<Inventory> _inventoryList;

        #region Constructor

        public Testing()
        {


        }

        [Fact]
        public void Add_In_Inventory()
        {
            var db = new Database();
            var inventory = new Inventory()
            {

                Id = 6,
                ProductId = 5,
                Quantity=5
               

            };

            var prgm = new Program();
            var list = prgm.AddInventory(inventory);
            Assert.Equal(6, db.InventoryList.Count);

        }
        [Fact]

        public void Delete_From_Inventory()
        {
          
            var db = new Database();
            var old = db.InventoryList.Count;
            var inventory = new Inventory()
            {

                Id = 1,
                ProductId = 1,
                Quantity=100,
                
                

            };
            var prgm = new Program();
            var list = prgm.DeleteInventory(inventory);
            Assert.NotEqual(list.Count, old);


           }


        [Fact]
        public void Update_Inventory()
        {
            var db = new Database();
            var prgm = new Program();
            var invemtoryObj= db.InventoryList.ToList().FirstOrDefault(x => x.Id == 3);
            invemtoryObj.Price = 40;

            prgm.UpdateInventory(invemtoryObj);

            Assert.Equal(40, invemtoryObj.Price);         
    
  

        }



        [Fact]
        public void Check_Out_From_Cart()
        {

            var db = new Database();
            

            var prgm = new Program();
            var list = prgm.CheckOutTheCartandUpdateInventory(db.CartList.ToList());

            Assert.Equal(95, db.InventoryList.ToList().FirstOrDefault(x => x.Id == 1).Quantity);
            Assert.Equal(150, db.InventoryList.ToList().FirstOrDefault(x => x.Id == 4).Quantity);




        }
        [Fact]
        public void Check_Item_Available()
        {
            var db = new Database();


            var prgm = new Program();
            var list = prgm.CheckOutTheCartandUpdateInventory(db.CartList.ToList());
            Mock<Program> chck = new Mock<Program>();
            chck.Setup(x => x.CheckProductIsExistInInventoryOrNot()).Returns(true);



            prgm.CheckOutTheCartandUpdateInventory(db.CartList.ToList());
            Assert.Equal(95, db.InventoryList.ToList().FirstOrDefault(x => x.Id == 1).Quantity);
            Assert.Equal(150, db.InventoryList.ToList().FirstOrDefault(x => x.Id == 4).Quantity);


        }
        #endregion
    }
}
