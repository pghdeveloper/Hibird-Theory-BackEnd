using Hibird_Theory_Backend.Interfaces;
using Hibird_Theory_Backend.Models;
using Newtonsoft.Json;
using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace Hibird_Theory_Backend.Services
{
    public class CalculationService: ICalculationService
    {
        public CalculationService ()
        {

        }

        public PizzaTotal Calculation(int pizzaCommitments)
        {
            //calculatione 5
            //convert pizza committments to dollar amount
            var dollarAmount = pizzaCommitments * .000015;

            // read demand vector (86 values)
            var finalDemand = JsonConvert.DeserializeObject<LeonMatrix>(System.IO.File.ReadAllText("finaldemand.json"));

            // add dolarAmount to demand[i], where i is index of foor service
            finalDemand.v81 = finalDemand.v81 + dollarAmount;
            // add 5 dollar (deliveary) to demand[j], j is index of "Transit & Ground Passengers"
            finalDemand.v49 = finalDemand.v49 + .000005;
            // as result updated demand
            string json = JsonConvert.SerializeObject(finalDemand, Formatting.Indented);
            // persist updart demand
            File.WriteAllText("finaldemand.json", json);

            // multiply (matrix operation) leonmatrix (86x86) by demand vector (86)
            // result leonresult vector (86)
            List<double> totalOutput = new List<double>();
            var leonMatrix = JsonConvert.DeserializeObject<List<LeonMatrix>>(System.IO.File.ReadAllText("leonMatrix.json"));
            foreach (var row in leonMatrix)
            {
                List<double> array = new List<double>();
                array.Add(row.v1 * finalDemand.v1);
                array.Add(row.v2 * finalDemand.v2);
                array.Add(row.v3 * finalDemand.v3);
                array.Add(row.v4 * finalDemand.v4);
                array.Add(row.v5 * finalDemand.v5);
                array.Add(row.v6 * finalDemand.v6);
                array.Add(row.v7 * finalDemand.v7);
                array.Add(row.v8 * finalDemand.v8);
                array.Add(row.v9 * finalDemand.v9);

                array.Add(row.v10 * finalDemand.v10);
                array.Add(row.v11 * finalDemand.v11);
                array.Add(row.v12 * finalDemand.v12);
                array.Add(row.v13 * finalDemand.v13);
                array.Add(row.v14 * finalDemand.v14);
                array.Add(row.v15 * finalDemand.v15);
                array.Add(row.v16 * finalDemand.v16);
                array.Add(row.v17 * finalDemand.v17);
                array.Add(row.v18 * finalDemand.v18);
                array.Add(row.v19 * finalDemand.v19);

                array.Add(row.v20 * finalDemand.v20);
                array.Add(row.v21 * finalDemand.v21);
                array.Add(row.v22 * finalDemand.v22);
                array.Add(row.v23 * finalDemand.v23);
                array.Add(row.v24 * finalDemand.v24);
                array.Add(row.v25 * finalDemand.v25);
                array.Add(row.v26 * finalDemand.v26);
                array.Add(row.v27 * finalDemand.v27);
                array.Add(row.v28 * finalDemand.v28);
                array.Add(row.v29 * finalDemand.v29);

                array.Add(row.v30 * finalDemand.v30);
                array.Add(row.v31 * finalDemand.v31);
                array.Add(row.v32 * finalDemand.v32);
                array.Add(row.v33 * finalDemand.v33);
                array.Add(row.v34 * finalDemand.v34);
                array.Add(row.v35 * finalDemand.v35);
                array.Add(row.v36 * finalDemand.v36);
                array.Add(row.v37 * finalDemand.v37);
                array.Add(row.v38 * finalDemand.v38);
                array.Add(row.v39 * finalDemand.v39);

                array.Add(row.v40 * finalDemand.v40);
                array.Add(row.v41 * finalDemand.v41);
                array.Add(row.v42 * finalDemand.v42);
                array.Add(row.v43 * finalDemand.v43);
                array.Add(row.v44 * finalDemand.v44);
                array.Add(row.v45 * finalDemand.v45);
                array.Add(row.v46 * finalDemand.v46);
                array.Add(row.v47 * finalDemand.v47);
                array.Add(row.v48 * finalDemand.v48);
                array.Add(row.v49 * finalDemand.v49);

                array.Add(row.v50 * finalDemand.v50);
                array.Add(row.v51 * finalDemand.v51);
                array.Add(row.v52 * finalDemand.v52);
                array.Add(row.v53 * finalDemand.v53);
                array.Add(row.v54 * finalDemand.v54);
                array.Add(row.v55 * finalDemand.v55);
                array.Add(row.v56 * finalDemand.v56);
                array.Add(row.v57 * finalDemand.v57);
                array.Add(row.v58 * finalDemand.v58);
                array.Add(row.v59 * finalDemand.v59);

                array.Add(row.v60 * finalDemand.v60);
                array.Add(row.v61 * finalDemand.v61);
                array.Add(row.v62 * finalDemand.v62);
                array.Add(row.v63 * finalDemand.v63);
                array.Add(row.v64 * finalDemand.v64);
                array.Add(row.v65 * finalDemand.v65);
                array.Add(row.v66 * finalDemand.v66);
                array.Add(row.v67 * finalDemand.v67);
                array.Add(row.v68 * finalDemand.v68);
                array.Add(row.v69 * finalDemand.v69);

                array.Add(row.v70 * finalDemand.v70);
                array.Add(row.v71 * finalDemand.v71);
                array.Add(row.v72 * finalDemand.v72);
                array.Add(row.v73 * finalDemand.v73);
                array.Add(row.v74 * finalDemand.v74);
                array.Add(row.v75 * finalDemand.v75);
                array.Add(row.v76 * finalDemand.v76);
                array.Add(row.v77 * finalDemand.v77);
                array.Add(row.v78 * finalDemand.v78);
                array.Add(row.v79 * finalDemand.v79);

                array.Add(row.v80 * finalDemand.v80);
                array.Add(row.v81 * finalDemand.v81);
                array.Add(row.v82 * finalDemand.v82);
                array.Add(row.v83 * finalDemand.v83);
                array.Add(row.v84 * finalDemand.v84);
                array.Add(row.v85 * finalDemand.v85);
                array.Add(row.v86 * finalDemand.v86);

                totalOutput.Add(array.Sum());

            }

            List<double> co2coef = new List<double>() {0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0865,
                0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,
                0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0865,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,
                0.0259,0.0259,0.0259,0.0259,0.0259,1.4618,1.4618,1.4618,1.4618,1.4618,1.4618,1.4618,0.0259,0.0259,0.0259,
                0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,
                0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.0259,0.1659,0.1659,
                0.1659,0.1659};

            List<double> employmentcoef = new List<double>() {3.0369,0.6056,5.2151,2.577,9.6574,3.5565,2.2712,5.2322,2.7188,
                3.7281,1.6199,1.8212,2.3976,3.3892,4.616,3.9024,3.1411,2.2322,4.2244,0.6852,1.5547,2.5026,2.9573,2.147,3.8495,
                3.681,3.5889,3.6062,2.7563,3.431,4.0533,4.4679,5.9271,4.7147,11.1198,5.1763,5.8035,5.6842,3.3638,3.8348,
                5.2534,5.5067,5.1226,2.1287,3.3606,5.3259,1.9027,3.1266,7.2689,4.7959,5.0237,7.242,6.7097,5.1863,3.4444,
                1.786,1.4848,6.2477,5.9638,3.6128,7.2709,5.294,4.1888,1.6521,0.5011,2.9034,0.3901,6.6737,7.4862,7.5445,
                4.4705,8.5558,7.2983,7.3975,8.3501,7.2122,4.5789,7.4059,4.4069,4.8077,5.2468,4.6868,3.936,8.5747,14.1519,
                10.2757};

            List<double> gdpcoef= new List<double>() {0.6703,0.5321,0.6683,0.9786,0.8743,0.8703,0.6921,0.7671,0.7685,0.6943,
                0.528,0.5815,0.6231,0.7047,0.7013,0.5847,0.5831,0.5964,0.6292,0.7972,0.7022,0.6122,0.5781,0.6652,0.702,0.7055,
                0.6812,0.6706,0.7131,0.6224,0.6679,0.7101,0.8213,0.6896,0.6726,0.6952,0.7613,0.7043,0.8037,0.6867,0.7148,
                0.7191,0.7292,0.6904,0.6795,0.5559,0.51,0.548,0.5032,0.7416,0.6261,0.7284,0.6748,0.8095,0.7997,0.6095,
                0.539,0.5398,0.6318,0.7861,0.6277,0.4582,0.6546,0.4782,0.7732,0.7388,0.5556,0.7157,0.6826,0.7273,0.6707,
                0.7647,0.7318,0.7153,0.721,0.6989,0.7064,0.5862,0.6569,0.7094,0.7098,0.8159,0.7012,0.7318,1,0.9309};

            List<double> energycoef = new List<double>() {0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0019,
                0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,
                0.0019,0.0019,0.0019,0.0019,0.0019,0.0019,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,
                0.0006,0.0006,0.0006,0.0006,0.0006,0.0315,0.0315,0.0315,0.0315,0.0315,0.0315,0.0315,0.0006,0.0006,
                0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,
                0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,0.0006,
                0.0036,0.0036,0.0036,0.0036};

            // multiply (loop though each value) leonresult  (86) by coeff (86) to get indicators
            var finalCommitment = JsonConvert.DeserializeObject<PizzaTotal>(System.IO.File.ReadAllText("dynamicwithcommitments.json"));
            finalCommitment.commitments = finalCommitment.commitments + 1;
            finalCommitment.amount = finalCommitment.amount + pizzaCommitments;

            int i = 0;
            foreach (var sector in finalCommitment.sectors)
            {
                sector.co2 = totalOutput[i] * co2coef[i];
                sector.employment = totalOutput[i] * employmentcoef[i];
                sector.gdp = totalOutput[i] * gdpcoef[i];
                sector.fossil = totalOutput[i] * energycoef[i];
            }
            // result new dynamicwithcommitments.json
            // persist dynamicwithcommitments.json

            // return dynamicwithcommitments.json

            // demand vector must to updated through each call
            var result = JsonConvert.DeserializeObject<PizzaTotal>(System.IO.File.ReadAllText("dynamicwithcommitments.json")); 

            //write file to dynamic json
            File.WriteAllText("dynamicwithcommitments.json", JsonConvert.SerializeObject(result));
            return result;
        }
    }
}