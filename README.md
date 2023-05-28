# Advanced-ImageEncryption

Advanced-ImageEncryption is a desktop application developed using C# on Visual Studio Code 2015. It provides advanced cryptography and steganography capabilities, allowing users to securely encrypt and decrypt various types of data with ease.

## Features

### 1. TextCrypt

The TextCrypt feature enables you to encrypt and decrypt text, making your shared information more secure. Follow these simple steps to use TextCrypt:

**Text Encryption**

1. Select the "Encryption" radio button in the Cryptography State Option.
2. Enter the text you want to encrypt in the Original Text section box.
3. Choose a unique password and confirm it in the Confirmation box.
4. Click the "Encrypt" button to finalize the encryption process.
5. The encrypted text will be displayed in the Encrypted Text section box on the right side.

**Text Decryption**

1. Select the "Decryption" radio button in the Cryptography State Option.
2. Paste the encrypted text into the Encrypted Text section box.
3. Enter the password used during encryption in the Confirmation box.
4. Click the "Decrypt" button to finalize the decryption process.
5. The decrypted text (original text) will be displayed in the Original Text section box on the left side.

### 2. IMageCrypt

The IMageCrypt feature allows you to hide text behind any type of image using steganography. Follow these steps to utilize this functionality:

1. Click on the "Open Image" menu option to open the Open File Dialog.
2. Choose an image file in which you want to hide your text and double-click on it.
3. The selected image will be displayed in the main picture box.
4. Enter the text you want to hide in the Secret Message box next to the main picture box.
5. Click the "Encrypt" button to hide the text within the image.
6. Use the "Save Image" option to save the image with the hidden text to your preferred location.

To display hidden text from an encrypted image:

1. Insert the encrypted image using the "Open Image" option.
2. Click the "Decrypt" option.
3. The hidden text will be displayed in the Secret Message box.

### 3. DataCrypt

The DataCrypt feature allows you to securely encrypt and decrypt any type of data. Follow these steps to utilize DataCrypt:

**Data Encryption**

1. Select the "Encryption" radio button in the Cryptography State Option.
2. Click the "Browse" button to locate the data you want to encrypt using the Open File Dialog.
3. Double-click on the data file you wish to encrypt.
4. Choose a save location for the encrypted data using the "Save In" button.
5. Enter a decryption key in the text box next to the "Key" label.
6. Click the "Encrypt" button to finalize the encryption process.

**Data Decryption**

1. Select the "Decryption" radio button in the Cryptography State Option.
2. Click the "Browse" button to locate the data you want to decrypt using the Open File Dialog.
3. Double-click on the data file you wish to decrypt.
4. Choose a save location for the decrypted data using the "Save In" button.
5. Enter the decryption key used during encryption in the text box next to the "Key" label.
6. Click the "Decrypt" button to finalize the decryption process.

## Requirements

- C# 6.0 or later
- Visual Studio Code 2015 or later

## Installation

1. Clone the repository: `git clone https://github.com/medahad/Advanced-ImageEncryption.git`
2. Open the project in Visual Studio Code.
3. Build the project to generate the executable file.

## Usage

1. Run the generated executable file.
2. Explore the different features available within the application.
3. Follow the instructions provided in the application for encryption, decryption, and hiding text within images.
4. Ensure that you have the necessary permissions to access and modify files.

## Contributing

Contributions are welcome! If you have any suggestions or encounter any issues, please submit a pull request or open an issue on the GitHub repository.

## License

This project is licensed under the [MIT License](LICENSE).

## Acknowledgements

We would like to thank the following resources and libraries for their contributions to this project:

- [Cryptography Library]([https://example.com](https://cryptobook.nakov.com/crypto-libraries-for-developers/c-crypto-libraries))
- [Steganography Library]([https://example.com](https://freecomputerbooks.com/Image-Steganography-and-Steganalysis.html))
- [Open File Dialog Library]([https://example.com](https://learn.microsoft.com/en-us/dotnet/api/system.windows.forms.openfiledialog?view=windowsdesktop-7.0))
