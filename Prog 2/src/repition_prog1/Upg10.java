package repition_prog1;

import java.util.ArrayList;

import javafx.animation.AnimationTimer;
import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.input.KeyCode;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class Upg10 extends Application{

	@Override
	public void start(Stage primaryStage) throws Exception {
		Rectangle player = new Rectangle(60, 90, Color.RED);
		Group root = new Group(player);
		Scene ps = new Scene(root, 500 , 500);
		primaryStage.setScene(ps);
		primaryStage.show();
		ArrayList<KeyCode> keysPressed = new ArrayList<KeyCode>();
		AnimationTimer at = new AnimationTimer() {

			@Override
			public void handle(long now) {
				//Runs when a key is pressed
				for (KeyCode key : keysPressed) {
					//hold++;
					switch (key) {
					case LEFT:
						player.setTranslateX(player.getTranslateX()-4);
					break;
					case RIGHT:
						player.setTranslateX(player.getTranslateX()+4);
						break;
					case UP:
						player.setTranslateY(player.getTranslateY()-4);
						break;
					case DOWN:
						player.setTranslateY(player.getTranslateY()+4);
						break;	
					default:
						break;
					}
					if(player.getTranslateX() > 440) {
						player.setTranslateX(440);
					}
					if(player.getTranslateY() > 410) {
						player.setTranslateY(410);
					}
					
					if(player.getTranslateX() < 0) {
						player.setTranslateX(0);
					}
					if(player.getTranslateY() < 0) {
						player.setTranslateY(0);
					}
				}
			}
		};
		
		// adds or removes keys from the key arraylist
				ps.setOnKeyPressed(e ->

				{
					KeyCode key = e.getCode();
					if (!keysPressed.contains(key))
						keysPressed.add(key);
				});

				ps.setOnKeyReleased(e -> {
					KeyCode key = e.getCode();
					if (keysPressed.contains(key))
						keysPressed.remove(key);
				});

				at.start();
	}
	
	public static void main(String[] args) {
		launch();
	}

}
