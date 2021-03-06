﻿using System;
using Apworks;

namespace ByteartRetail.Domain.Model
{
    /// <summary>
    /// 表示商品的分类信息的对象。
    /// </summary>
    public class Categorization : IAggregateRoot
    {
        #region Ctor
        /// <summary>
        /// 初始化一个<c>Categorization</c>类型的实例。
        /// </summary>
        public Categorization() { }
        /// <summary>
        /// 初始化一个<c>Categorization</c>类型的实例。
        /// </summary>
        /// <param name="categoryID">类别对象的ID。</param>
        /// <param name="productID">商品对象的ID。</param>
        public Categorization(Guid productID, Guid categoryID)
        {
            CategoryID = categoryID;
            ProductID = productID;
        }
        #endregion

        #region Properties
        public Guid ID { get; set; }

        /// <summary>
        /// 获取或设置类别对象的ID。
        /// </summary>
        public Guid CategoryID { get; set; }

        /// <summary>
        /// 获取或设置商品对象的ID。
        /// </summary>
        public Guid ProductID { get; set; }

        #endregion

        #region Public Methods
        /// <summary>
        /// 返回表示当前Object的字符串。
        /// </summary>
        /// <returns>表示当前对象的字符串。</returns>
        public override string ToString()
        {
            return string.Format("CategoryID: {0}, ProductID: {1}", CategoryID, ProductID);
        }
        /// <summary>
        /// 创建商品与分类之间的关系。
        /// </summary>
        /// <param name="product">商品实体。</param>
        /// <param name="category">分类实体。</param>
        /// <returns>描述商品与分类之间关系的实体。</returns>
        public static Categorization CreateCategorization(Product product, Category category)
        {
            return new Categorization(product.ID, category.ID);
        }
        #endregion
    }
}
