import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router';

import ProductForm from '../ProductForm';

const UpdateProductContainer = () => {
  const [product, setProduct] = useState(undefined);
  const {state} = useLocation();
  const { existProduct } = state; // Read values passed on state
  
  useEffect(() => {
    if (existProduct) {
      setProduct({
        id:existProduct.id,
        name: existProduct.name,
        description: existProduct.description,
        details: existProduct.details,
        decreasePrice: existProduct.decreasePrice,
        price: existProduct.price,
        updatedDate: existProduct.updatedDate,
        isFeatured: existProduct.isFeatured,
        categoryId: existProduct.categoryId,
        brandId: existProduct.brandId,
        imageFile:existProduct.images,
      });
    }
  }, [existProduct]);

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className='text-center'>
        Update Product {existProduct?.name}
      </h2>
      <br/>
      <div className='row'>
        {
          product && (<ProductForm
            initialProductForm={product}
          />)
        }
      </div>
    </div>
  )
};

export default UpdateProductContainer;