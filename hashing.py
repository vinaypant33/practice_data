import hashlib

def sha256_hash(text):
    # Encode the input text
    encoded_text = text.encode('utf-8')
    # Perform SHA-256 hashing
    hash_object = hashlib.sha256(encoded_text)
    # Get the hexadecimal representation of the hash
    hex_hash = hash_object.hexdigest()
    return hex_hash

# Example usage
input_text = input("Enter the text you want to hash: ")
hashed_text = sha256_hash(input_text)
print(f"SHA-256 hash of '{input_text}' is: {hashed_text}")
