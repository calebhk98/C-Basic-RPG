using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Following_Tutorial;
using System.Media;

namespace Following_Tutorial{
    public partial class Game : Form{

        public class Enemy{
            public int health, damage, cooldown, speed, points;
            public string name, tag;
            public Point location;
            public Size size;
            public PictureBox picture;
			

            public Enemy(Form form, int x, int y){
                location = new Point(x, y);
                name = "Enemy0";
                size = new Size(32, 32);
                health = 100;
                damage = 1;
				speed = 1;
				points = 1;
                cooldown = 1;
                tag = "Enemy";
                name = "Monster";
				picture = new PictureBox{
                    Name=name,
					//Image =  Properties.Resource.Char,
					Image = Properties.Resource.Enemy,
					SizeMode = PictureBoxSizeMode.Zoom,
					Size =size,
                    Location = location,
                    Visible = true
                };
                
                form.Controls.Add(picture);
            }
           
        }


		public class Food {
			public int health, Vitality;
			public string name, tag;
			public Point location;
			public Size size;
			public PictureBox picture;
			public Food() {
				size = new Size(32, 32);

			}
			
		}


		public class Apples:Food {
				public Apples(Form form, int x, int y ) {
				location = new Point(x, y);
				health = 10;
				Vitality = 0;
				name = "Apple";
				tag = "Apple";
				picture = new PictureBox {
					Name = name,
					Image = Properties.Resource.Infobox_Apple,
					SizeMode = PictureBoxSizeMode.Zoom,
					Size = size,
					Location = location,
					Visible = true,
					Tag = "Apple"
			};
				form.Controls.Add(picture);
			}
		}


		public class Banana:Food {
				public Banana( Form form, int x, int y ) {
				location = new Point(x, y);
				health = 15;
				Vitality = 30;
				name = "Banana";
				tag = "Banana";
				picture = new PictureBox {
					Name = name,
					Image = Properties.Resource.Banana,
					SizeMode = PictureBoxSizeMode.Zoom,
					Size = size,
					Location = location,
					Visible = true,
					Tag = "Banana"
				};
				form.Controls.Add(picture);
			}
		}



		public class Inv:Food{
			public int ID;
			public Inv( Form form, int x, int y, int id ) {
				size = new Size(32, 32);
				location = new Point(x, y);
				name = "Inv";
				tag = "";
				ID=id;
				picture = new PictureBox {
					Name = name,
					Image = Properties.Resource.Inv,
					BackgroundImage= Properties.Resource.Inv,
					SizeMode = PictureBoxSizeMode.Zoom,
					Size = size,
					Location = location,
					Visible = true,
					Tag = tag,
					
				};
				picture.Click += new EventHandler(Clicked);
				form.Controls.Add(picture);
			}
			void Clicked( object sender, EventArgs e ) {
				Console.WriteLine(this.ID);
				//Trying to run
				//AddToInv(myInv[ID]);
				//or 
				//AddToInv(this);
			}
			public void TestClick() {
				

			}

			/*
			public event EventHandler<MouseEventArgs> Click;
			protected void OnClick( MouseEventArgs e ) {
				EventHandler<MouseEventArgs> handler = Click;
				if(handler != null) {
					handler(this, e);
					Console.WriteLine("Clicked");
				}

			}
			internal void CheckIfClicked( MouseEventArgs e ) {
				Console.WriteLine("Clicked");
			}*/
		}

		public void Test() {


			//myInv [0].Click

		}
		
		List<Enemy> testEnemies = new List<Enemy>();
		
		List<Food> testFood = new List<Food>();
		Inv [] myInv= new Inv[10];

		bool alive;
		int lvl = 1;
		int XP = 0;
		Label deathLabel = new Label()
		{
			Name = "Death Label",
				};

		public Game(string Username){
            InitializeComponent();
            health.Maximum = 100;
            health.Value = 100;
            maxHealth.Text = health.Maximum.ToString();
            currentHealth.Text = health.Value.ToString();
			alive = true;
			String User = Username;
			userName.Text = User;
			//newEnemies.Add( new Enemy(this, 500, 300));
			for(int i = 0; i < 10; i++) {
				myInv [i] = new Inv(this, 965-(38*i), 12,i);
				
			}


			testEnemies.Add(new Enemy(this, 300, 100));
			
			testFood.Add(new Apples(this, 400, 300));


			testFood.Add(new Banana(this, 400, 200));
			Test();
            

			System.IO.Stream song = Properties.Resource.Upbeat_Happy_Orchestral_2_by_Gavin_Luke____Epic_Classical_Music_;
			SoundPlayer player = new SoundPlayer(song);

			//player.Open(new WaveReader(song));
			player.Play();



		}

		

		public void Lose(int damage) {
			if(health.Value > damage)
			{
				health.Value -= damage;
				//Console.WriteLine("Should be taking damage.");
			}
			else if((health.Value-damage)<=0){
				health.Value = 0;
				Death();
				//Console.WriteLine("Should be 0.");
			}
			currentHealth.Text = health.Value.ToString();
		}

        public void Heal(int healing) {
            if (health.Value + healing <= health.Maximum)
            {
                health.Value += healing;
            }
            else if (health.Value == health.Maximum) {
                // Do nothing
            }
            else
            {
                health.Value = health.Maximum;
            }
			currentHealth.Text = health.Value.ToString();
			if(health.Value > 0){
				alive = true;
				DeathScreen();
			}
		}

        public void Vitality(int stamina) {

            health.Maximum += stamina;
            maxHealth.Text = health.Maximum.ToString();

        }

        public void Collisions(){
            
            for (int i = 0; i<testEnemies.Count; i++) {
                if (player.Bounds.IntersectsWith(testEnemies[i].picture.Bounds)){
                    Lose(testEnemies[i].damage);
                    testEnemies[i].health -= 9;
                    if (testEnemies[i].health<=0){
						testEnemies [i].picture.Visible = false;
						XP += testEnemies [i].points;
						testEnemies.RemoveAt(i);
						XPlabel.Text = "XP : " + XP;
                    }
                }
                //Console.WriteLine("Enemy "+ i+ " has "+ testEnemies[i].health+ " health." );
            }
			for(int i = 0; i < testFood.Count; i++ ) {
				if(player.Bounds.IntersectsWith(testFood [i].picture.Bounds) && testFood[i].picture.Visible) {
					AddToInv(testFood[i]);
				}
				
			}
			if(player.Location.X <= -5) {
				player.Left = 1000;

			}
			if(player.Location.X >= 1005) {
				player.Left = 0;

			}
			if(player.Location.Y <= 50) {
				player.Top = 700;

			}
			if(player.Location.Y >= 710) {
				player.Top = 50;

			}


		}

        public void HurtEnemy() { }

        public void AddToInv(Food item) {


			for(int i = 0; i < 10; i++) {
				if(myInv [i].tag == "") {
					myInv[i].health=item.health;
					myInv [i].picture.Image = item.picture.Image;
					myInv [i].tag = item.tag;
					myInv [i].Vitality= item.Vitality;
					

					break;

				}

			}
			

			//remove from form
			testFood.Remove(item);
            //release memory by disposing
            item.picture.Dispose();
        }

        private void Game_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        public void InventoryClicks(Inv item) {
			
			if(alive)
			{
				if(item.tag != "")
				{
					if(health.Value != health.Maximum)
					{
						System.IO.Stream song = Properties.Resource.Click;
						SoundPlayer player = new SoundPlayer(song);

						//player.Open(new WaveReader(song));
						player.Play();

						Heal(item.health);
						Vitality(item.Vitality);
						item.health = 0;
						item.Vitality = 0;
						item.tag = "";
						item.picture.Image = Properties.Resource.Inv;
						
					}

				}
			}
        }

		public void EnemyAI() {
			for(int i = 0; i < testEnemies.Count; i++) {

				Point enemyNextSpot;
				int x = 0;
				int y = 0;
				if(player.Location.X> testEnemies [i].picture.Location.X+ testEnemies [i].speed) {
					x = testEnemies [i].speed;
				}
				if(player.Location.X < testEnemies [i].picture.Location.X- testEnemies [i].speed) {
					x = -testEnemies [i].speed;
				}
				if(player.Location.Y > testEnemies [i].picture.Location.Y+ testEnemies [i].speed) {
					y = testEnemies [i].speed;
				}
				if(player.Location.Y < testEnemies [i].picture.Location.Y- testEnemies [i].speed) {
					y = -testEnemies [i].speed;
				}
				enemyNextSpot = new Point(testEnemies [i].picture.Location.X+x, testEnemies [i].picture.Location.Y+y);
				
				testEnemies [i].picture.Location = enemyNextSpot;



				//Console.WriteLine("Enemy "+ i+ " has "+ testEnemies[i].health+ " health." );
			}


		}

		#region InvClick
		public void Inv_Click(Inv spot) {
			InventoryClicks(spot);
		}

		#endregion

		public void Death() {
			alive = false;
			DeathScreen();

		}
		public void DeathScreen()
		{			
			if(!alive)
			{
				deathLabel.Visible = true;
				deathLabel.Text = "YOU DIED!";
				deathLabel.Location = player.Location;
				Console.Beep();
				//Console.WriteLine("Text should be Here" + alive);
				this.Controls.Add(deathLabel);
				deathLabel.BringToFront();
			}
			if(alive)
			{
				deathLabel.Visible = false;
				deathLabel.Text = "";
				deathLabel.Location = new Point(9999,9999);
				Console.Beep();
				//Console.WriteLine("Text should be gone"+alive);
			}
		}

		private void TranslateTransformAngle( PaintEventArgs e )
		{

			// Set world transform of graphics object to rotate.
			e.Graphics.RotateTransform(30.0F);

			// Then to translate, prepending to world transform.
			e.Graphics.TranslateTransform(100.0F, 0.0F);

			// Draw translated, rotated ellipse to screen.
			e.Graphics.DrawEllipse(new Pen(Color.Blue, 3), 0, 0, 200, 80);
		}
		public void Levels() {
			if(testEnemies.Count == 0) {
				Random rnd = new Random();
				
				lvl++;
				for(int i = 0; i < lvl; i++) {
					int X = rnd.Next(1, 1000); // creates a number between 1 and 12
					int Y = rnd.Next(1, 700);   // creates a number between 1 and 6
					testEnemies.Add(new Enemy(this, X, Y));

				}
				for(int i = 0; i < lvl; i++) {
					testEnemies [i].damage = (int)(Math.Pow(1.1, lvl));
					testEnemies [i].health = (int)(Math.Pow(1.1,lvl)*100);
					testEnemies [i].speed = lvl;
					testEnemies [i].points = lvl * 3;

				}

				if(rnd.Next(1, 1000) < 750) {
					int X = rnd.Next(40, 1000);
					int Y = rnd.Next(40, 700);
					testFood.Add(new Apples(this, X, Y));
				}
				else {
					int X = rnd.Next(40, 1000);
					int Y = rnd.Next(40, 700);
					testFood.Add(new Banana(this, X, Y));
				}
				for(int i=0; i<10; i++) {
					if(rnd.Next(1, 1000) < (int)(100 * lvl / (lvl + i))) {
						if(rnd.Next(1, 1000) < 750) {
							int X = rnd.Next(1, 1000);
							int Y = rnd.Next(1, 700);
							testFood.Add(new Apples(this, X, Y));
						}
						else {
							int X = rnd.Next(1, 1000);
							int Y = rnd.Next(1, 700);
							testFood.Add(new Banana(this, X, Y));
						}

					}
				}
				
			}


		}

		bool movementUp = false;
		bool movementDown = false;
		bool movementLeft = false;
		bool movementRight = false;

		private void Game_KeyDown( object sender, KeyEventArgs key )
		{
			int VerticalMovement = 0;
			int HorizontalMovement = 0;
			if(!Menu.Enabled) {
				if(alive) {
					#region Movement
					VerticalMovement = 0;
					HorizontalMovement = 0;

					//Console.WriteLine("Horizontal is: " + HorizontalMovement + " Vertical is: " + VerticalMovement);
					if(key.KeyCode == Keys.W || key.KeyCode == Keys.Up) {
						movementUp = true;
					}
					if(key.KeyCode == Keys.S || key.KeyCode == Keys.Down) {
						movementDown = true;
					}
					if(key.KeyCode == Keys.A || key.KeyCode == Keys.Left) {
						movementLeft = true;
					}
					if(key.KeyCode == Keys.D || key.KeyCode == Keys.Right) {
						movementRight = true;
					}
					if(movementUp) {
						VerticalMovement -= 5; // How to change better
						userName.Location = new Point((player.Location.X + HorizontalMovement), (player.Location.Y + VerticalMovement + 32));
					}
					if(movementDown) {
						VerticalMovement += 5;
						userName.Location = new Point((player.Location.X + HorizontalMovement), (player.Location.Y + VerticalMovement + 32));
					}
					if(movementLeft) {
						HorizontalMovement -= 5;
						userName.Location = new Point((player.Location.X + HorizontalMovement), (player.Location.Y + VerticalMovement + 32));
					}
					if(movementRight) {
						HorizontalMovement += 5;
						userName.Location = new Point((player.Location.X + HorizontalMovement), (player.Location.Y + VerticalMovement + 32));
					}
					player.Location = new Point((player.Location.X + HorizontalMovement), (player.Location.Y + VerticalMovement));

					//Console.WriteLine("Horizontal is: " + HorizontalMovement + " Vertical is: " + VerticalMovement);
					//Console.WriteLine("Move Up: "+ movementUp + " Move Down: " + movementDown + " Move Left: " + movementLeft + " Move Right: " + movementRight);
					#endregion
					Collisions();
					EnemyAI();
					Levels();

					 #region Inventory by number
					if(key.KeyCode == Keys.D0) {
						InventoryClicks(myInv[0]);
					}
					else if(key.KeyCode == Keys.D9) {
						InventoryClicks(myInv [1]);
					}
					else if(key.KeyCode == Keys.D8) {
						InventoryClicks(myInv [2]);
					}
					else if(key.KeyCode == Keys.D7) {
						InventoryClicks(myInv [3]);
					}
					else if(key.KeyCode == Keys.D6) {
						InventoryClicks(myInv [4]);
					}
					else if(key.KeyCode == Keys.D5) {
						InventoryClicks(myInv [5]);
					}
					else if(key.KeyCode == Keys.D4) {
						InventoryClicks(myInv [6]);
					}
					else if(key.KeyCode == Keys.D3) {
						InventoryClicks(myInv [7]);
					}
					else if(key.KeyCode == Keys.D2) {
						InventoryClicks(myInv [8]);
					}
					else if(key.KeyCode == Keys.D1) {
						InventoryClicks(myInv [9]);
					}

					#endregion
				}
				if(userName.Text == "Caleb") {
					#region Health
					if(key.KeyCode == Keys.H) {
						Heal(10);
					}
					if(key.KeyCode == Keys.K) {
						Lose(10);
					}
					if(key.KeyCode == Keys.J) {
						Vitality(10);
					}
					#endregion
				}

			}
			#region Menu
			if(key.KeyCode == Keys.Escape && Menu.Enabled==false) {
				Menu.Enabled = true;
				Menu.Visible = true;
			}
			else if(key.KeyCode == Keys.Escape && Menu.Enabled == true) {
				Menu.Enabled = false;
				Menu.Visible = false;
			}
			#endregion
		}

		private void Game_KeyUp( object sender, KeyEventArgs key ){
			
			if(key.KeyCode == Keys.W || key.KeyCode == Keys.Up) {
				movementUp = false;
			}
			if(key.KeyCode == Keys.S || key.KeyCode == Keys.Down) {
				movementDown = false;
			}
			if(key.KeyCode == Keys.A || key.KeyCode == Keys.Left) {
				movementLeft = false;
			}
			if(key.KeyCode == Keys.D || key.KeyCode == Keys.Right) {
				movementRight = false;
			}
			
		}

		private void Quit_Click( object sender, EventArgs e ) {
			Application.Exit();
		}
	}           
}
