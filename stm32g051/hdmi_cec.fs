\
\ @file hdmi_cec.fs
\ @brief HDMI-CEC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief CEC control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_CR_CECEN                            \ CEC enable
$00000002 constant HDMI_CEC_CEC_CR_TXSOM                            \ Tx start of message
$00000004 constant HDMI_CEC_CEC_CR_TXEOM                            \ Tx end of message


\
\ @brief This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$00000007 constant HDMI_CEC_CEC_CFGR_SFT                            \ Signal free time
$00000008 constant HDMI_CEC_CEC_CFGR_RXTOL                          \ Rx-tolerance
$00000010 constant HDMI_CEC_CEC_CFGR_BRESTP                         \ Rx-stop on bit rising error The BRESTP bit is set and cleared by software.
$00000020 constant HDMI_CEC_CEC_CFGR_BREGEN                         \ Generate error-bit on bit rising error
$00000040 constant HDMI_CEC_CEC_CFGR_LBPEGEN                        \ Generate error-bit on long bit period error
$00000080 constant HDMI_CEC_CEC_CFGR_BRDNOGEN                       \ Avoid error-bit generation in broadcast
$00000100 constant HDMI_CEC_CEC_CFGR_SFTOP                          \ SFT option bit The SFTOPT bit is set and cleared by software.
$7fff0000 constant HDMI_CEC_CEC_CFGR_OAR                            \ Own addresses configuration
$80000000 constant HDMI_CEC_CEC_CFGR_LSTN                           \ Listen mode LSTN bit is set and cleared by software.


\
\ @brief CEC Tx data register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$000000ff constant HDMI_CEC_CEC_TXDR_TXD                            \ Tx Data register. TXD is a write-only register containing the data byte to be transmitted. Note: TXD must be written when TXSTART=1


\
\ @brief CEC Rx Data Register
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$000000ff constant HDMI_CEC_CEC_RXDR_RXD                            \ Rx Data register. RXD is read-only and contains the last data byte which has been received from the CEC line.


\
\ @brief CEC Interrupt and Status Register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_ISR_RXBR                            \ Rx-Byte Received The RXBR bit is set by hardware to inform application that a new byte has been received from the CEC line and stored into the RXD buffer. RXBR is cleared by software write at 1.
$00000002 constant HDMI_CEC_CEC_ISR_RXEND                           \ End Of Reception RXEND is set by hardware to inform application that the last byte of a CEC message is received from the CEC line and stored into the RXD buffer. RXEND is set at the same time of RXBR. RXEND is cleared by software write at 1.
$00000004 constant HDMI_CEC_CEC_ISR_RXOVR                           \ Rx-Overrun RXOVR is set by hardware if RXBR is not yet cleared at the time a new byte is received on the CEC line and stored into RXD. RXOVR assertion stops message reception so that no acknowledge is sent. In case of broadcast, a negative acknowledge is sent. RXOVR is cleared by software write at 1.
$00000008 constant HDMI_CEC_CEC_ISR_BRE                             \ Rx-Bit Rising Error BRE is set by hardware in case a Data-Bit waveform is detected with Bit Rising Error. BRE is set either at the time the misplaced rising edge occurs, or at the end of the maximum BRE tolerance allowed by RXTOL, in case rising edge is still longing. BRE stops message reception if BRESTP=1. BRE generates an Error-Bit on the CEC line if BREGEN=1. BRE is cleared by software write at 1.
$00000010 constant HDMI_CEC_CEC_ISR_SBPE                            \ Rx-Short Bit Period Error SBPE is set by hardware in case a Data-Bit waveform is detected with Short Bit Period Error. SBPE is set at the time the anticipated falling edge occurs. SBPE generates an Error-Bit on the CEC line. SBPE is cleared by software write at 1.
$00000020 constant HDMI_CEC_CEC_ISR_LBPE                            \ Rx-Long Bit Period Error LBPE is set by hardware in case a Data-Bit waveform is detected with Long Bit Period Error. LBPE is set at the end of the maximum bit-extension tolerance allowed by RXTOL, in case falling edge is still longing. LBPE always stops reception of the CEC message. LBPE generates an Error-Bit on the CEC line if LBPEGEN=1. In case of broadcast, Error-Bit is generated even in case of LBPEGEN=0. LBPE is cleared by software write at 1.
$00000040 constant HDMI_CEC_CEC_ISR_RXACKE                          \ Rx-Missing Acknowledge In receive mode, RXACKE is set by hardware to inform application that no acknowledge was seen on the CEC line. RXACKE applies only for broadcast messages and in listen mode also for not directly addressed messages (destination address not enabled in OAR). RXACKE aborts message reception. RXACKE is cleared by software write at 1.
$00000080 constant HDMI_CEC_CEC_ISR_ARBLST                          \ Arbitration Lost ARBLST is set by hardware to inform application that CEC device is switching to reception due to arbitration lost event following the TXSOM command. ARBLST can be due either to a contending CEC device starting earlier or starting at the same time but with higher HEADER priority. After ARBLST assertion TXSOM bit keeps pending for next transmission attempt. ARBLST is cleared by software write at 1.
$00000100 constant HDMI_CEC_CEC_ISR_TXBR                            \ Tx-Byte Request TXBR is set by hardware to inform application that the next transmission data has to be written to TXDR. TXBR is set when the 4th bit of currently transmitted byte is sent. Application must write the next byte to TXDR within 6 nominal data-bit periods before transmission underrun error occurs (TXUDR). TXBR is cleared by software write at 1.
$00000200 constant HDMI_CEC_CEC_ISR_TXEND                           \ End of Transmission TXEND is set by hardware to inform application that the last byte of the CEC message has been successfully transmitted. TXEND clears the TXSOM and TXEOM control bits. TXEND is cleared by software write at 1.
$00000400 constant HDMI_CEC_CEC_ISR_TXUDR                           \ Tx-Buffer Underrun In transmission mode, TXUDR is set by hardware if application was not in time to load TXDR before of next byte transmission. TXUDR aborts message transmission and clears TXSOM and TXEOM control bits. TXUDR is cleared by software write at 1
$00000800 constant HDMI_CEC_CEC_ISR_TXERR                           \ Tx-Error In transmission mode, TXERR is set by hardware if the CEC initiator detects low impedance on the CEC line while it is released. TXERR aborts message transmission and clears TXSOM and TXEOM controls. TXERR is cleared by software write at 1.
$00001000 constant HDMI_CEC_CEC_ISR_TXACKE                          \ Tx-Missing Acknowledge Error In transmission mode, TXACKE is set by hardware to inform application that no acknowledge was received. In case of broadcast transmission, TXACKE informs application that a negative acknowledge was received. TXACKE aborts message transmission and clears TXSOM and TXEOM controls. TXACKE is cleared by software write at 1.


\
\ @brief CEC interrupt enable register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant HDMI_CEC_CEC_IER_RXBRIE                          \ Rx-byte received interrupt enable The RXBRIE bit is set and cleared by software.
$00000002 constant HDMI_CEC_CEC_IER_RXENDIE                         \ End of reception interrupt enable The RXENDIE bit is set and cleared by software.
$00000004 constant HDMI_CEC_CEC_IER_RXOVRIE                         \ Rx-buffer overrun interrupt enable The RXOVRIE bit is set and cleared by software.
$00000008 constant HDMI_CEC_CEC_IER_BREIE                           \ Bit rising error interrupt enable The BREIE bit is set and cleared by software.
$00000010 constant HDMI_CEC_CEC_IER_SBPEIE                          \ Short bit period error interrupt enable The SBPEIE bit is set and cleared by software.
$00000020 constant HDMI_CEC_CEC_IER_LBPEIE                          \ Long bit period error interrupt enable The LBPEIE bit is set and cleared by software.
$00000040 constant HDMI_CEC_CEC_IER_RXACKIE                         \ Rx-missing acknowledge error interrupt enable The RXACKIE bit is set and cleared by software.
$00000080 constant HDMI_CEC_CEC_IER_ARBLSTIE                        \ Arbitration lost interrupt enable The ARBLSTIE bit is set and cleared by software.
$00000100 constant HDMI_CEC_CEC_IER_TXBRIE                          \ Tx-byte request interrupt enable The TXBRIE bit is set and cleared by software.
$00000200 constant HDMI_CEC_CEC_IER_TXENDIE                         \ Tx-end of message interrupt enable The TXENDIE bit is set and cleared by software.
$00000400 constant HDMI_CEC_CEC_IER_TXUDRIE                         \ Tx-underrun interrupt enable The TXUDRIE bit is set and cleared by software.
$00000800 constant HDMI_CEC_CEC_IER_TXERRIE                         \ Tx-error interrupt enable The TXERRIE bit is set and cleared by software.
$00001000 constant HDMI_CEC_CEC_IER_TXACKIE                         \ Tx-missing acknowledge error interrupt enable The TXACKEIE bit is set and cleared by software.


\
\ @brief HDMI-CEC
\
$40007800 constant HDMI_CEC_CEC_CR  \ offset: 0x00 : CEC control register
$40007804 constant HDMI_CEC_CEC_CFGR  \ offset: 0x04 : This register is used to configure the HDMI-CEC controller. It is mandatory to write CEC_CFGR only when CECEN=0.
$40007808 constant HDMI_CEC_CEC_TXDR  \ offset: 0x08 : CEC Tx data register
$4000780c constant HDMI_CEC_CEC_RXDR  \ offset: 0x0C : CEC Rx Data Register
$40007810 constant HDMI_CEC_CEC_ISR  \ offset: 0x10 : CEC Interrupt and Status Register
$40007814 constant HDMI_CEC_CEC_IER  \ offset: 0x14 : CEC interrupt enable register

