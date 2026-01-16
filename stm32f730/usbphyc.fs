\
\ @file usbphyc.fs
\ @brief USBPHYC register interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief USBPHYC PLL1 control register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000001 constant USBPHYC_PLL1_PLL1EN                              \ Enable the PLL1 inside PHY
$0000000e constant USBPHYC_PLL1_PLL1SEL                             \ : Controls the PHY PLL1 input clock frequency selection


\
\ @brief USBPHYC tuning control register
\ Address offset: 0x0C
\ Reset value: 0x00000004
\

$00000001 constant USBPHYC_TUNE_INCURREN                            \ Controls the current boosting function
$00000002 constant USBPHYC_TUNE_INCURRINT                           \ Controls PHY current boosting
$00000004 constant USBPHYC_TUNE_LFSCAPEN                            \ : Enables the Low Full Speed feedback capacitor
$00000008 constant USBPHYC_TUNE_HSDRVSLEW                           \ Controls the HS driver slew rate
$00000010 constant USBPHYC_TUNE_HSDRVDCCUR                          \ Decreases the HS driver DC level
$00000020 constant USBPHYC_TUNE_HSDRVDCLEV                          \ Increases the HS Driver DC level. Not applicable during the HS Test J and Test K data transfer
$00000040 constant USBPHYC_TUNE_HSDRVCURINCR                        \ Enable the HS driver current increase feature
$00000080 constant USBPHYC_TUNE_FSDRVRFADJ                          \ Tuning pin to adjust the full speed rise/fall time
$00000100 constant USBPHYC_TUNE_HSDRVRFRED                          \ High Speed rise-fall reduction enable
$00001e00 constant USBPHYC_TUNE_HSDRVCHKITRM                        \ HS Driver current trimming pins for choke compensation
$00006000 constant USBPHYC_TUNE_HSDRVCHKZTRM                        \ Controls the PHY bus HS driver impedance tuning for choke compensation
$00018000 constant USBPHYC_TUNE_SQLCHCTL                            \ Adjust the squelch DC threshold value
$00020000 constant USBPHYC_TUNE_HDRXGNEQEN                          \ Enables the HS Rx Gain Equalizer
$00040000 constant USBPHYC_TUNE_STAGSEL                             \ HS Tx staggering enable
$00080000 constant USBPHYC_TUNE_HSFALLPREEM                         \ HS Fall time control of single ended signals during pre-emphasis
$00300000 constant USBPHYC_TUNE_HSRXOFF                             \ : HS Receiver Offset adjustment
$00400000 constant USBPHYC_TUNE_SHTCCTCTLPROT                       \ Enables the short circuit protection circuitry in LS/FS driver
$00800000 constant USBPHYC_TUNE_SQLBYP                              \ This pin is used to bypass the squelch inter-locking circuitry


\
\ @brief USBPHYC LDO control and status register
\ Address offset: 0x18
\ Reset value: 0x00000001
\

$00000001 constant USBPHYC_LDO_LDO_USED                             \ Indicates the presence of the LDO in the chip
$00000002 constant USBPHYC_LDO_LDO_STATUS                           \ Monitors the status of the PHY's LDO
$00000004 constant USBPHYC_LDO_LDO_DISABLE                          \ Controls disable of the High Speed PHY's LDO


\
\ @brief USBPHYC register interface
\
$40017c00 constant USBPHYC_PLL1   \ offset: 0x00 : USBPHYC PLL1 control register
$40017c0c constant USBPHYC_TUNE   \ offset: 0x0C : USBPHYC tuning control register
$40017c18 constant USBPHYC_LDO    \ offset: 0x18 : USBPHYC LDO control and status register

