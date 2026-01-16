\
\ @file i2c1.fs
\ @brief I2C2 event interrupt
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief Control register 1
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant I2C1_CR1_PE                                      \ Peripheral enable
$00000002 constant I2C1_CR1_SMBUS                                   \ SMBus mode
$00000008 constant I2C1_CR1_SMBTYPE                                 \ SMBus type
$00000010 constant I2C1_CR1_ENARP                                   \ ARP enable
$00000020 constant I2C1_CR1_ENPEC                                   \ PEC enable
$00000040 constant I2C1_CR1_ENGC                                    \ General call enable
$00000080 constant I2C1_CR1_NOSTRETCH                               \ Clock stretching disable (Slave mode)
$00000100 constant I2C1_CR1_START                                   \ Start generation
$00000200 constant I2C1_CR1_STOP                                    \ Stop generation
$00000400 constant I2C1_CR1_ACK                                     \ Acknowledge enable
$00000800 constant I2C1_CR1_POS                                     \ Acknowledge/PEC Position (for data reception)
$00001000 constant I2C1_CR1_PEC                                     \ Packet error checking
$00002000 constant I2C1_CR1_ALERT                                   \ SMBus alert
$00008000 constant I2C1_CR1_SWRST                                   \ Software reset


\
\ @brief Control register 2
\ Address offset: 0x04
\ Reset value: 0x00000000
\

$0000003f constant I2C1_CR2_FREQ                                    \ Peripheral clock frequency
$00000100 constant I2C1_CR2_ITERREN                                 \ Error interrupt enable
$00000200 constant I2C1_CR2_ITEVTEN                                 \ Event interrupt enable
$00000400 constant I2C1_CR2_ITBUFEN                                 \ Buffer interrupt enable
$00000800 constant I2C1_CR2_DMAEN                                   \ DMA requests enable
$00001000 constant I2C1_CR2_LAST                                    \ DMA last transfer


\
\ @brief Own address register 1
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant I2C1_OAR1_ADD0                                   \ Interface address
$000000fe constant I2C1_OAR1_ADD7                                   \ Interface address
$00000300 constant I2C1_OAR1_ADD10                                  \ Interface address
$00008000 constant I2C1_OAR1_ADDMODE                                \ Addressing mode (slave mode)


\
\ @brief Own address register 2
\ Address offset: 0x0C
\ Reset value: 0x00000000
\

$00000001 constant I2C1_OAR2_ENDUAL                                 \ Dual addressing mode enable
$000000fe constant I2C1_OAR2_ADD2                                   \ Interface address


\
\ @brief Data register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$000000ff constant I2C1_DR_DR                                       \ 8-bit data register


\
\ @brief Status register 1
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant I2C1_SR1_SB                                      \ Start bit (Master mode)
$00000002 constant I2C1_SR1_ADDR                                    \ Address sent (master mode)/matched (slave mode)
$00000004 constant I2C1_SR1_BTF                                     \ Byte transfer finished
$00000008 constant I2C1_SR1_ADD10                                   \ 10-bit header sent (Master mode)
$00000010 constant I2C1_SR1_STOPF                                   \ Stop detection (slave mode)
$00000040 constant I2C1_SR1_RXNE                                    \ Data register not empty (receivers)
$00000080 constant I2C1_SR1_TXE                                     \ Data register empty (transmitters)
$00000100 constant I2C1_SR1_BERR                                    \ Bus error
$00000200 constant I2C1_SR1_ARLO                                    \ Arbitration lost (master mode)
$00000400 constant I2C1_SR1_AF                                      \ Acknowledge failure
$00000800 constant I2C1_SR1_OVR                                     \ Overrun/Underrun
$00001000 constant I2C1_SR1_PECERR                                  \ PEC Error in reception
$00004000 constant I2C1_SR1_TIMEOUT                                 \ Timeout or Tlow error
$00008000 constant I2C1_SR1_SMBALERT                                \ SMBus alert


\
\ @brief Status register 2
\ Address offset: 0x18
\ Reset value: 0x00000000
\

$00000001 constant I2C1_SR2_MSL                                     \ Master/slave
$00000002 constant I2C1_SR2_BUSY                                    \ Bus busy
$00000004 constant I2C1_SR2_TRA                                     \ Transmitter/receiver
$00000010 constant I2C1_SR2_GENCALL                                 \ General call address (Slave mode)
$00000020 constant I2C1_SR2_SMBDEFAULT                              \ SMBus device default address (Slave mode)
$00000040 constant I2C1_SR2_SMBHOST                                 \ SMBus host header (Slave mode)
$00000080 constant I2C1_SR2_DUALF                                   \ Dual flag (Slave mode)
$0000ff00 constant I2C1_SR2_PEC                                     \ acket error checking register


\
\ @brief Clock control register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000fff constant I2C1_CCR_CCR                                     \ Clock control register in Fast/Standard mode (Master mode)
$00004000 constant I2C1_CCR_DUTY                                    \ Fast mode duty cycle
$00008000 constant I2C1_CCR_F_S                                     \ I2C master mode selection


\
\ @brief TRISE register
\ Address offset: 0x20
\ Reset value: 0x00000002
\

$0000003f constant I2C1_TRISE_TRISE                                 \ Maximum rise time in Fast/Standard mode (Master mode)


\
\ @brief FLTR register
\ Address offset: 0x24
\ Reset value: 0x00000000
\

$0000000f constant I2C1_FLTR_DNF                                    \ Digital noise filter
$00000010 constant I2C1_FLTR_ANOFF                                  \ Analog noise filter OFF


\
\ @brief I2C2 event interrupt
\
$40005400 constant I2C1_CR1       \ offset: 0x00 : Control register 1
$40005404 constant I2C1_CR2       \ offset: 0x04 : Control register 2
$40005408 constant I2C1_OAR1      \ offset: 0x08 : Own address register 1
$4000540c constant I2C1_OAR2      \ offset: 0x0C : Own address register 2
$40005410 constant I2C1_DR        \ offset: 0x10 : Data register
$40005414 constant I2C1_SR1       \ offset: 0x14 : Status register 1
$40005418 constant I2C1_SR2       \ offset: 0x18 : Status register 2
$4000541c constant I2C1_CCR       \ offset: 0x1C : Clock control register
$40005420 constant I2C1_TRISE     \ offset: 0x20 : TRISE register
$40005424 constant I2C1_FLTR      \ offset: 0x24 : FLTR register

