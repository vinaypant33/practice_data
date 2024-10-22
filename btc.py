
import bitcoin

private_key = bitcoin.random_key()
public_key = bitcoin.privkey_to_pubkey(private_key)




# print(private_key)
print(public_key)

