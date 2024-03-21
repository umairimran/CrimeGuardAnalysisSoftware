# predict.py

import joblib
import sys
import json

def predict(input_data):
    # Load the trained model
    model = joblib.load('knn_model.pkl')
    
    # Make predictions
    predictions = model.predict(input_data)
    
    return predictions.tolist()

if __name__ == "__main__":
    # Read input data from command line arguments
    input_data = json.loads(sys.argv[1])
    
    # Call the predict function and print predictions
    predictions = predict(input_data)
    print(json.dumps(predictions))
