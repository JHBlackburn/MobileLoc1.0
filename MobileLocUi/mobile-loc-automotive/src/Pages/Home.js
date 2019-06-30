import React from "../../node_modules/react";
import Dropdown from "../Components/Dropdown";
import staticMakes from "../SamplePayloads/MakesApi.json";

var carMakes = [{ carMakeId: 1, carMakeName: "hello" }];

function fetchMakes(thecarMakes) {
  const newArray = thecarMakes.map(make => make => ({
    id: make.carMakeId,
    name: make.carMakeName
  }));
  console.log(newArray);
  return newArray;
}

function Home(props) {
  return (
    <div>
      <Dropdown
        class="SelectMakesDropDown"
        dropdownItems={fetchMakes(staticMakes)}
      />
    </div>
  );
}

export default Home;
