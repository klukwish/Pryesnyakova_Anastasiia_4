using Lab4;

Vessel tanker = new Tanker();
Vessel cargo_ship = new Cargo_ship();
Vessel boat = new Boat();

Fleet fleet = new Fleet();
fleet.VesselsAdd(boat);
fleet.VesselsAdd(cargo_ship);
fleet.VesselsAdd(tanker);
fleet.Show();
tanker.Move();
tanker.FuelCount();

