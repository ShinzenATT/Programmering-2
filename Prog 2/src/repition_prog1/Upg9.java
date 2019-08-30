package repition_prog1;

import javafx.application.Application;
import javafx.scene.Group;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.paint.Color;
import javafx.scene.shape.Circle;
import javafx.stage.Stage;

public class Upg9 extends Application {

	@Override
	public void start(Stage pStage) throws Exception {
		Button redo = new Button("Refresh");
		redo.setOpacity(0.7);
		Group root = new Group(circles(), redo);
		redo.setOnAction(event->{
			root.getChildren().clear();
			root.getChildren().addAll(circles(), redo);
		});
		Scene start = new Scene(root ,500, 500);
		pStage.setScene(start);
		pStage.show();
		
	}
	
	public static Group circles() {
		Group root = new Group();
		for(int i = 0; i < 10 ; i++) {
			root.getChildren().add(new Circle(Math.random() * 500, Math.random()*500, Math.random() * 60, Color.BLUE));
		}
		return root;
	}
	
	public static void main(String[] args) {
		launch();
	}
	
}
