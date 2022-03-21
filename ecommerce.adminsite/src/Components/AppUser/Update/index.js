import React, { useEffect, useState } from 'react'
import { useLocation } from 'react-router';

import AppUserForm from '../AppUserForm';

const UpdateAppUserContainer = () => {
  const [appUser, setAppUser] = useState(undefined);
  const {state} = useLocation();
  const { existAppUser } = state; // Read values passed on state
  
  useEffect(() => {
    if (existAppUser) {
      setAppUser({
        id: existAppUser.id,
        name: existAppUser.name,
      });
    }
  }, [existAppUser]);

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className='text-center'>Update AppUser</h2>
      <br/>
      <div className='row'>
        {
          appUser && (<AppUserForm
            initialAppUserForm={appUser}
  
          />)
        }
      </div>
    </div>
  )
};

export default UpdateAppUserContainer;
