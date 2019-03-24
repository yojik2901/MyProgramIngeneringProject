using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace MyProgramIngeneringProject
{
    public class ProductFactory: IProductFactory
    {
        #region Realization Singlon

        private static IProductFactory _instance;

        private ProductFactory() {}

        [MethodImpl(MethodImplOptions.Synchronized)]
        public static IProductFactory GetInstance()
        {
            if(_instance == null)
                _instance = new ProductFactory();

            return _instance;
        }

        #endregion

        #region Create product

        private static Dictionary<int, IProduct> _products = new Dictionary<int, IProduct>();

        public IProduct CreateProduct(int id)
        {
            IProduct product = null;

            if (!_products.TryGetValue(id, out product))
            {
                switch (id)
                {
                    case 1:

                        break;
                    case 2:

                        break;
                    case 3:

                        break;
                    case 4:

                        break;
                    case 5:

                        break;
                }

                _products[id] = product;
            }

            return product;
        }

        #endregion
    }
}