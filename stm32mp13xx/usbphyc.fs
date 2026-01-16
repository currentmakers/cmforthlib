\
\ @file usbphyc.fs
\ @brief USBPHYC
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief USBPHYC PLL control register
\ Address offset: 0x00
\ Reset value: 0xC0000000
\

$0000007f constant USBPHYC_USBPHYC_PLL_PLLNDIV                      \ Loop division factor of PLL (integer part)
$00000380 constant USBPHYC_USBPHYC_PLL_PLLODF                       \ PLL output division factor
$03fffc00 constant USBPHYC_USBPHYC_PLL_PLLFRACIN                    \ PLL fractional input PLLFRACIN is the fractional input of the PLL divider.
$04000000 constant USBPHYC_USBPHYC_PLL_PLLEN                        \ PLL enable This bit enables the PLL.
$08000000 constant USBPHYC_USBPHYC_PLL_PLLSTRB                      \ PLL strobe This bit allows to control an asynchronous strobe signal provided as an input to the fractional controller. A rising edge of PLLSTRB signal indicates to the fractional controller that a new fractional word is to be loaded.
$10000000 constant USBPHYC_USBPHYC_PLL_PLLSTRBYP                    \ PLL strobe bypass Bypass the strobe signal. If set to 1 before setting PLLEN=1, then the PLL will start up in fractional mode depending on the setting of PLLFRACCTL.
$20000000 constant USBPHYC_USBPHYC_PLL_PLLFRACCTL                   \ PLL fractional mode control
$40000000 constant USBPHYC_USBPHYC_PLL_PLLDITHEN0                   \ PLL dither 2 (triangular) This bit enables the triangular dither for the PLL.
$80000000 constant USBPHYC_USBPHYC_PLL_PLLDITHEN1                   \ PLL dither 1 (rectangular) This bit enables the rectangular dither for the PLL.


\
\ @brief USBPHYC misc control register
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000001 constant USBPHYC_USBPHYC_MISC_SWITHOST                    \ Switch host Controls main switch connecting USB PHY 2nd port between USB host controller and USB OTG controller. This register is static.
$00000006 constant USBPHYC_USBPHYC_MISC_PPCKDIS                     \ Intelligent per HS PHY port clock gating control This register is static.


\
\ @brief USBPHYC PHY 1 TUNE register
\ Address offset: 0x10C
\ Reset value: 0x04070004
\

$00000001 constant USBPHYC_USBPHYC_TUNE1_INCURREN                   \ The bit enables the current boosting function.
$00000002 constant USBPHYC_USBPHYC_TUNE1_INCURRINT                  \ Current boosting value This bit controls the PHY current boosting value.
$00000004 constant USBPHYC_USBPHYC_TUNE1_LFSCAPEN                   \ Low full speed enable This bit enables the low full speed feedback capacitor.
$00000008 constant USBPHYC_USBPHYC_TUNE1_HSDRVSLEW                  \ HS driver slew rate This bit controls the HS driver slew rate.
$00000010 constant USBPHYC_USBPHYC_TUNE1_HSDRVDCCUR                 \ HS driver DC level This bit allows to decrease the HS driver DC level.
$00000020 constant USBPHYC_USBPHYC_TUNE1_HSDRVDCLEV                 \ HS driver DC level This bit allows to increase the HS driver DC level. I is not applicable during the HS test J and test K data transfer.
$00000040 constant USBPHYC_USBPHYC_TUNE1_HSDRVCURINCR               \ Enable the HS driver current increase feature
$00000080 constant USBPHYC_USBPHYC_TUNE1_FSDRVRFADJ                 \ Tuning pin to adjust the full speed rise/fall time
$00000100 constant USBPHYC_USBPHYC_TUNE1_HSDRVRFRED                 \ High-speed rise-fall reduction enable
$00001e00 constant USBPHYC_USBPHYC_TUNE1_HSDRVCHKITRM               \ HS driver choke current trim This bitfield controls the HS driver current trimming pins for choke compensation.
$00006000 constant USBPHYC_USBPHYC_TUNE1_HSDRVCHKZTRM               \ HS driver choke impedance trim This bitfield controls the PHY bus HS driver impedance tuning for choke compensation.
$000f8000 constant USBPHYC_USBPHYC_TUNE1_OTPCOMP                    \ OTP compensation code
$00300000 constant USBPHYC_USBPHYC_TUNE1_SQLCHCTL                   \ Squelch control This bitfield adjusts the squelch DC threshold value.
$00400000 constant USBPHYC_USBPHYC_TUNE1_HDRXGNEQEN                 \ Enable HS Rx gain equalizer
$01800000 constant USBPHYC_USBPHYC_TUNE1_HSRXOFF                    \ HS receiver offset adjustment
$02000000 constant USBPHYC_USBPHYC_TUNE1_HSFALLPREEM                \ HS fall time pre-emphasis This bit enables the HS fall time control of single ended signals during pre-emphasis:
$04000000 constant USBPHYC_USBPHYC_TUNE1_SHTCCTCTLPROT              \ Short circuit control protection This bit enables the short circuit protection circuitry in LS/FS driver.
$08000000 constant USBPHYC_USBPHYC_TUNE1_STAGSEL                    \ Staggering selection This bit enables the HS Tx staggering.


\
\ @brief USBPHYC PHY 2 TUNE register
\ Address offset: 0x20C
\ Reset value: 0x04070004
\

$00000001 constant USBPHYC_USBPHYC_TUNE2_INCURREN                   \ The bit enables the current boosting function.
$00000002 constant USBPHYC_USBPHYC_TUNE2_INCURRINT                  \ Current boosting value This bit controls the PHY current boosting value.
$00000004 constant USBPHYC_USBPHYC_TUNE2_LFSCAPEN                   \ Low full speed enable This bit enables the low full speed feedback capacitor.
$00000008 constant USBPHYC_USBPHYC_TUNE2_HSDRVSLEW                  \ HS driver slew rate This bit controls the HS driver slew rate.
$00000010 constant USBPHYC_USBPHYC_TUNE2_HSDRVDCCUR                 \ HS driver DC level This bit allows to decrease the HS driver DC level.
$00000020 constant USBPHYC_USBPHYC_TUNE2_HSDRVDCLEV                 \ HS driver DC level This bit allows to increase the HS driver DC level. I is not applicable during the HS test J and test K data transfer.
$00000040 constant USBPHYC_USBPHYC_TUNE2_HSDRVCURINCR               \ Enable the HS driver current increase feature
$00000080 constant USBPHYC_USBPHYC_TUNE2_FSDRVRFADJ                 \ Tuning pin to adjust the full speed rise/fall time
$00000100 constant USBPHYC_USBPHYC_TUNE2_HSDRVRFRED                 \ High-speed rise-fall reduction enable
$00001e00 constant USBPHYC_USBPHYC_TUNE2_HSDRVCHKITRM               \ HS driver choke current trim This bitfield controls the HS driver current trimming pins for choke compensation.
$00006000 constant USBPHYC_USBPHYC_TUNE2_HSDRVCHKZTRM               \ HS driver choke impedance trim This bitfield controls the PHY bus HS driver impedance tuning for choke compensation.
$000f8000 constant USBPHYC_USBPHYC_TUNE2_OTPCOMP                    \ OTP compensation code
$00300000 constant USBPHYC_USBPHYC_TUNE2_SQLCHCTL                   \ Squelch control This bitfield adjusts the squelch DC threshold value.
$00400000 constant USBPHYC_USBPHYC_TUNE2_HDRXGNEQEN                 \ Enable HS Rx gain equalizer
$01800000 constant USBPHYC_USBPHYC_TUNE2_HSRXOFF                    \ HS receiver offset adjustment
$02000000 constant USBPHYC_USBPHYC_TUNE2_HSFALLPREEM                \ HS fall time pre-emphasis This bit enables the HS fall time control of single ended signals during pre-emphasis:
$04000000 constant USBPHYC_USBPHYC_TUNE2_SHTCCTCTLPROT              \ Short circuit control protection This bit enables the short circuit protection circuitry in LS/FS driver.
$08000000 constant USBPHYC_USBPHYC_TUNE2_STAGSEL                    \ Staggering selection This bit enables the HS Tx staggering.


\
\ @brief USBPHYC VERSION register
\ Address offset: 0xFFC
\ Reset value: 0x00000010
\

$0000000f constant USBPHYC_USBPHYC_VERR_MINREV                      \ Minor revision
$000000f0 constant USBPHYC_USBPHYC_VERR_MAJREV                      \ Major revision


\
\ @brief USBPHYC
\
$5a006000 constant USBPHYC_USBPHYC_PLL  \ offset: 0x00 : USBPHYC PLL control register
$5a006008 constant USBPHYC_USBPHYC_MISC  \ offset: 0x08 : USBPHYC misc control register
$5a00610c constant USBPHYC_USBPHYC_TUNE1  \ offset: 0x10C : USBPHYC PHY 1 TUNE register
$5a00620c constant USBPHYC_USBPHYC_TUNE2  \ offset: 0x20C : USBPHYC PHY 2 TUNE register
$5a006ffc constant USBPHYC_USBPHYC_VERR  \ offset: 0xFFC : USBPHYC VERSION register

