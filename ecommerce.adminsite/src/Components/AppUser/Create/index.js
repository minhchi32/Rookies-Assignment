import React, { useState } from "react";

import AppUserFormContainer from "../AppUserForm";

const CreateAppUserContainer = () => {

  return (
    <div className='ml-5 container'>
      <br/>
      <h2 className="text-center">Create New AppUser</h2>
      <br/>
      <div className='row'>
        <AppUserFormContainer />
      </div>
    </div>
  );
};

export default CreateAppUserContainer;
