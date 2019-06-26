import React from "../../node_modules/react";
import payload from "../SamplePayloads/MakesApi.json";

function FetchDropdownData(props) {
  let data = payload.map(item => {
    // props.id = item.carMakeId ;
    // props.name = item.carMakeName;
    console.log(item.carMakeId);
  });
  return data;
}

export default FetchDropdownData;
