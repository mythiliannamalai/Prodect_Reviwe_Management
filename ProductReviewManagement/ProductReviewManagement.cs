using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ProductReviewManagementlinq
{
    public class ProductReviewManagement
    {
        List<ProductReview> ProductReviewList;
        DataTable dataTable = new DataTable();
        public ProductReviewManagement()
        {
            ProductReviewList = new List<ProductReview>();
            dataTable.Columns.Add("ProductID", typeof(int));
            dataTable.Columns.Add("UserID", typeof(int));
            dataTable.Columns.Add("Rating", typeof(int));
            dataTable.Columns.Add("Review", typeof(string));
            dataTable.Columns.Add("IsLike", typeof(bool));            
        }
        //UC-1 Add product review
        public void AddProductReviewManagement()
        {
            ProductReviewList.Add(new ProductReview() { ProductID = 1, UserID = 1, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 2, UserID = 2, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 3, UserID = 3, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 4, UserID = 4, Rating = 4, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 5, UserID = 5, Rating = 2, Review = "nice", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 6, UserID = 6, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 7, UserID = 7, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 8, UserID = 8, Rating = 2, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 9, UserID = 9, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 10, UserID = 10, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 11, UserID = 11, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 12, UserID = 12, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 13, UserID = 13, Rating = 1, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 14, UserID = 14, Rating = 2, Review = "very bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 15, UserID = 15, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 16, UserID = 16, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 17, UserID = 17, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 18, UserID = 18, Rating = 2, Review = "average", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 19, UserID = 19, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 20, UserID = 20, Rating = 3, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 21, UserID = 21, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 22, UserID = 22, Rating = 2, Review = "bad", IsLike = false });
            ProductReviewList.Add(new ProductReview() { ProductID = 23, UserID = 23, Rating = 2, Review = "good", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 24, UserID = 24, Rating = 4, Review = "average", IsLike = true });
            ProductReviewList.Add(new ProductReview() { ProductID = 25, UserID = 25, Rating = 2, Review = "average", IsLike = true });
            Console.WriteLine("Product Review is Added");
        }        
        public void DisplayProductReviewList(List<ProductReview> ProductsReviewList)
        {
            foreach (var ProductReview in ProductReviewList)
            {
                Console.WriteLine("Product ID: {0}, \nUser ID: {1}, \nRating: {2}, \nReview: {3}, " +
                "\nIs Like: {4} \n", ProductReview.ProductID, ProductReview.UserID, ProductReview.Rating, ProductReview.Review,
                ProductReview.IsLike);
            }
        }
        //UC-2 Retrieve top 3 records from the list
        public void RetrieveTopThreeRecords(List<ProductReview> ProductReviewList)
        {
            var recordedData = (from productReviews in ProductReviewList orderby productReviews.Rating descending select productReviews).Take(3).ToList();

            foreach (var recordedRecord in recordedData)
            {
                Console.WriteLine("Product ID: {0}, \nUser ID: {1}, \nRating: {2}, \nReview: {3}, " +
                "\nIs Like: {4} \n", recordedRecord.ProductID, recordedRecord.UserID, recordedRecord.Rating, recordedRecord.Review,
                recordedRecord.IsLike);
            }
        }
        //UC-3 Management - Retrieve all record from the list who’s rating are greater then 3
        public void SelectedRecords(List<ProductReview> ProductReview)
        {
            var recordedData = from productReviews in ProductReview
                               where (productReviews.ProductID == 1 ||
                               productReviews.ProductID == 4 ||
                               productReviews.ProductID == 9) && (productReviews.Rating > 3)
                               select productReviews;

            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.ProductID + " " + "UserId:- " + list.UserID
                + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike :- " + list.IsLike);
            }
        }
        //UC-4  Retrieve count of review present for each productID
        public void RetrieveProductID(List<ProductReview> ProductReview)
        {
            int count=1;
            var recordedData = ProductReview.GroupBy(x => x.ProductID).Select(x => new { ProductID = x.Key, Count = x.Count() });
            Console.WriteLine("Count of records by ProductID: ");
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductID:" + list.ProductID + "--->" + "Count: " + count);
                count++;                
            }
        }
        //UC-5 Retrieve only productId and review from the list for all records.
        public void RetrieveProductIDAndReview(List<ProductReview> ProductReview)
        {
            var recordedData = (from list in ProductReview select new { list.ProductID, list.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ToString());
            }
        }
        //UC-6 skip top 5 records from the list
        public void SkipTopFive(List<ProductReview> ProductReview)
        {
            var recordedData = (from list in ProductReview orderby list.Rating ascending select list).Skip(5);
            foreach (var list in recordedData)
            {
                Console.WriteLine("ProductId:- " + list.ProductID + " " + "UserId:- " + list.UserID
                + " " + "Rating:- " + list.Rating + " " + "Review:- " + list.Review + " " + "IsLike :- " + list.IsLike);
            }
        }
        //UC-7 Retrieve only userId and review from the list for all records.
        public void RetrieveUserIDAndReview(List<ProductReview> ProductReview)
        {
            var recordedData = (from list in ProductReview select new { list.UserID, list.Review });
            foreach (var list in recordedData)
            {
                Console.WriteLine(list.ToString());
            }
        }
        //UC-8 Create DataTable using C# and Add ProductID, UserID, Rating, Review and isLike fields in that.
        //- Add 25 default values in datatable list which we have UC created
        public void AddProductDetailsInDataTable()
        {           
            dataTable.Rows.Add (1,1,1,"good",true);
            dataTable.Rows.Add(2,2,1,"good",true);
            dataTable.Rows.Add(3,3,1,"good",true);
            dataTable.Rows.Add( 4,4,4,"good",true );
            dataTable.Rows.Add(5,5,2,"nice",false );
            dataTable.Rows.Add(6,6,2,"bad",false);
            dataTable.Rows.Add(7,7,2,"bad",false );
            dataTable.Rows.Add(8,8,2,"good",true);
            dataTable.Rows.Add(9,9,3,"bad",false);
            dataTable.Rows.Add(10,10,3,"bad",false);
            dataTable.Rows.Add(11,11,1,"good",true);
            dataTable.Rows.Add(12,12,1,"good",true);
            dataTable.Rows.Add(13,13,1,"good",true);
            dataTable.Rows.Add(14,14,2,"very bad",false);
            dataTable.Rows.Add(15,15,2,"bad",false);
            dataTable.Rows.Add(16,16,2,"bad",false);
            dataTable.Rows.Add(17,17,2,"bad",false);
            dataTable.Rows.Add(18,18,2,"average",true);
            dataTable.Rows.Add(19,19,3,"bad",false);
            dataTable.Rows.Add(20,20,3,"bad",false);
            dataTable.Rows.Add(21,21,2,"bad",false);
            dataTable.Rows.Add(22,22,2,"bad",false);
            dataTable.Rows.Add(23,23,2,"good",true);
            dataTable.Rows.Add(24,24,4,"average",true);
            dataTable.Rows.Add(25,25, 2,"average",true);
            Console.WriteLine("The Product details are added...");
        }
    }
}
