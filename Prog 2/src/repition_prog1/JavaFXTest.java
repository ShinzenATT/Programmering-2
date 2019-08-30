package repition_prog1;

import javafx.application.Application;
import javafx.scene.Scene;
import javafx.scene.control.Button;
import javafx.scene.control.Label;
import javafx.scene.layout.BorderPane;
import javafx.scene.layout.HBox;
import javafx.scene.paint.Color;
import javafx.scene.shape.Rectangle;
import javafx.stage.Stage;

public class JavaFXTest extends Application{

	@Override
	public void start(Stage primary) throws Exception {
		//Vbox and HBox is a thing
		BorderPane root = new BorderPane();
		root.setTop(new Rectangle(500, 150, Color.BLUE));
		HBox buttons = new HBox();
		Button exit = new Button("Exit");
		exit.setOnAction(event->{
			primary.close();
		});
		buttons.getChildren().addAll(new Button("Home"), new Button("Help"), exit);
		root.setBottom(buttons);
		root.setLeft(new Label("left"));
		root.setRight(new Label("right"));
		root.setCenter(new Label("center"));
		Scene scene = new Scene(root, 500, 500);
		primary.setScene(scene);
		primary.show();
	}
	
	public static void main(String[] args) {
		launch();
	}
	
}
