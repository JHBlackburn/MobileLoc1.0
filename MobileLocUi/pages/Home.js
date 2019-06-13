import React from "react";
import PawsibleHeader from "../shared/PawsibleHeader";
import PawsibleTable from "../shared/PawsibleTable";
import AddPet from "../shared/AddPet";

function Home(props) {
  return (
    <div>
      <PawsibleHeader text={"Pawsible Pets"} />
      <AddPet getPets={props.getPets} />
      <PawsibleTable tableData={props.pets} />
    </div>
  );
}

export default Home;
