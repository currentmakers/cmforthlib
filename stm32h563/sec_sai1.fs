\
\ @file sec_sai1.fs
\ @brief Serial audio interface
\
\ This file is auto-generated from SVD file.
\ DO NOT EDIT MANUALLY.
\

.include ../common.fs

\
\ @brief SAI global configuration register
\ Address offset: 0x00
\ Reset value: 0x00000000
\

$00000003 constant SEC_SAI1_SAI_GCR_SYNCIN                          \ Synchronization inputs These bits are set and cleared by software. Refer to for information on how to program this field. These bits must be set when both audio blocks (A and B) are disabled. They are meaningful if one of the two audio blocks is defined to operate in synchronous mode with an external SAI (SYNCEN[1:0] = 10 in SAI_ACR1 or in SAI_BCR1 registers).
$00000030 constant SEC_SAI1_SAI_GCR_SYNCOUT                         \ Synchronization outputs These bits are set and cleared by software.


\
\ @brief SAI configuration register 1
\ Address offset: 0x04
\ Reset value: 0x00000040
\

$00000003 constant SEC_SAI1_SAI_ACR1_MODE                           \ SAIx audio block mode These bits are set and cleared by software. They must be configured when SAIx audio block is disabled. Note: When the audio block is configured in SPDIF mode, the master transmitter mode is forced (MODE[1:0] = 00).
$0000000c constant SEC_SAI1_SAI_ACR1_PRTCFG                         \ Protocol configuration These bits are set and cleared by software. These bits have to be configured when the audio block is disabled.
$000000e0 constant SEC_SAI1_SAI_ACR1_DS                             \ Data size These bits are set and cleared by software. These bits are ignored when the SPDIF protocols are selected (bit PRTCFG[1:0]), because the frame and the data size are fixed in such case. When the companding mode is selected through COMP[1:0] bits, DS[1:0] are ignored since the data size is fixed to 8 bits by the algorithm. These bits must be configured when the audio block is disabled.
$00000100 constant SEC_SAI1_SAI_ACR1_LSBFIRST                       \ Least significant bit first This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in AC'97 audio protocol since AC'97 data are always transferred with the MSB first. This bit has no meaning in SPDIF audio protocol since in SPDIF data are always transferred with LSB first.
$00000200 constant SEC_SAI1_SAI_ACR1_CKSTR                          \ Clock strobing edge This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in SPDIF audio protocol.
$00000c00 constant SEC_SAI1_SAI_ACR1_SYNCEN                         \ Synchronization enable These bits are set and cleared by software. They must be configured when the audio subblock is disabled. Note: The audio subblock should be configured as asynchronous when SPDIF mode is enabled.
$00001000 constant SEC_SAI1_SAI_ACR1_MONO                           \ Mono mode This bit is set and cleared by software. It is meaningful only when the number of slots is equal to 2. When the mono mode is selected, slot 0 data are duplicated on slot 1 when the audio block operates as a transmitter. In reception mode, the slot1 is discarded and only the data received from slot 0 are stored. Refer to for more details.
$00002000 constant SEC_SAI1_SAI_ACR1_OUTDRIV                        \ Output drive This bit is set and cleared by software. Note: This bit has to be set before enabling the audio block and after the audio block configuration.
$00010000 constant SEC_SAI1_SAI_ACR1_SAIEN                          \ Audio block enable This bit is set by software. To switch off the audio block, the application software must program this bit to 0 and poll the bit till it reads back 0, meaning that the block is completely disabled. Before setting this bit to 1, check that it is set to 0, otherwise the enable command is not taken into account. This bit allows controlling the state of the SAI audio block. If it is disabled when an audio frame transfer is ongoing, the ongoing transfer completes and the cell is fully disabled at the end of this audio frame transfer. Note: When the SAI block (A or B) is configured in master mode, the clock must be present on the SAI block input before setting SAIEN bit.
$00020000 constant SEC_SAI1_SAI_ACR1_DMAEN                          \ DMA enable This bit is set and cleared by software. Note: Since the audio block defaults to operate as a transmitter after reset, the MODE[1:0] bits must be configured before setting DMAEN to avoid a DMA request in receiver mode.
$00080000 constant SEC_SAI1_SAI_ACR1_NODIV                          \ No divider This bit is set and cleared by software.
$03f00000 constant SEC_SAI1_SAI_ACR1_MCKDIV                         \ Master clock divider These bits are set and cleared by software. Otherwise, The master clock frequency is calculated according to the formula given in . These bits have no meaning when the audio block is slave. They have to be configured when the audio block is disabled.
$04000000 constant SEC_SAI1_SAI_ACR1_OSR                            \ Oversampling ratio for master clock This bit is meaningful only when NODIV bit is set to 0.
$08000000 constant SEC_SAI1_SAI_ACR1_MCKEN                          \ Master clock generation enable


\
\ @brief SAI configuration register 2
\ Address offset: 0x08
\ Reset value: 0x00000000
\

$00000007 constant SEC_SAI1_SAI_ACR2_FTH                            \ FIFO threshold. This bit is set and cleared by software.
$00000008 constant SEC_SAI1_SAI_ACR2_FFLUSH                         \ FIFO flush. This bit is set by software. It is always read as 0. This bit should be configured when the SAI is disabled.
$00000010 constant SEC_SAI1_SAI_ACR2_TRIS                           \ Tristate management on data line. This bit is set and cleared by software. It is meaningful only if the audio block is configured as a transmitter. This bit is not used when the audio block is configured in SPDIF mode. It should be configured when SAI is disabled. Refer to for more details.
$00000020 constant SEC_SAI1_SAI_ACR2_MUTE                           \ Mute. This bit is set and cleared by software. It is meaningful only when the audio block operates as a transmitter. The MUTE value is linked to value of MUTEVAL if the number of slots is lower or equal to 2, or equal to 0 if it is greater than 2. Refer to for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00000040 constant SEC_SAI1_SAI_ACR2_MUTEVAL                        \ Mute value. This bit is set and cleared by software.It must be written before enabling the audio block: SAIEN. This bit is meaningful only when the audio block operates as a transmitter, the number of slots is lower or equal to 2 and the MUTE bit is set. If more slots are declared, the bit value sent during the transmission in mute mode is equal to 0, whatever the value of MUTEVAL. if the number of slot is lower or equal to 2 and MUTEVAL = 1, the MUTE value transmitted for each slot is the one sent during the previous frame. Refer to for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00001f80 constant SEC_SAI1_SAI_ACR2_MUTECNT                        \ Mute counter. These bits are set and cleared by software. They are used only in reception mode. The value set in these bits is compared to the number of consecutive mute frames detected in reception. When the number of mute frames is equal to this value, the flag MUTEDET is set and an interrupt is generated if bit MUTEDETIE is set. Refer to for more details.
$00002000 constant SEC_SAI1_SAI_ACR2_CPL                            \ Complement bit. This bit is set and cleared by software. It defines the type of complement to be used for companding mode Note: This bit has effect only when the companding mode is -Law algorithm or A-Law algorithm.
$0000c000 constant SEC_SAI1_SAI_ACR2_COMP                           \ Companding mode. These bits are set and cleared by software. The -Law and the A-Law log are a part of the CCITT G.711 recommendation, the type of complement that is used depends on CPL bit. The data expansion or data compression are determined by the state of bit MODE[0]. The data compression is applied if the audio block is configured as a transmitter. The data expansion is automatically applied when the audio block is configured as a receiver. Refer to for more details. Note: Companding mode is applicable only when Free protocol mode is selected.


\
\ @brief SAI frame configuration register
\ Address offset: 0x0C
\ Reset value: 0x00000007
\

$000000ff constant SEC_SAI1_SAI_AFRCR_FRL                           \ Frame length. These bits are set and cleared by software. They define the audio frame length expressed in number of SCK clock cycles: the number of bits in the frame is equal to FRL[7:0] + 1. The minimum number of bits to transfer in an audio frame must be equal to 8, otherwise the audio block behaves in an unexpected way. This is the case when the data size is 8 bits and only one slot 0 is defined in NBSLOT[4:0] of SAI_xSLOTR register (NBSLOT[3:0] = 0000). In master mode, if the master clock (available on MCLK_x pin) is used, the frame length should be aligned with a number equal to a power of 2, ranging from 8 to 256. When the master clock is not used (NODIV = 1), it is recommended to program the frame length to an value ranging from 8 to 256. These bits are meaningless and are not used in AC'97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
$00007f00 constant SEC_SAI1_SAI_AFRCR_FSALL                         \ Frame synchronization active level length. These bits are set and cleared by software. They specify the length in number of bit clock (SCK) + 1 (FSALL[6:0] + 1) of the active level of the FS signal in the audio frame These bits are meaningless and are not used in AC'97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
$00010000 constant SEC_SAI1_SAI_AFRCR_FSDEF                         \ Frame synchronization definition. This bit is set and cleared by software. When the bit is set, the number of slots defined in the SAI_xSLOTR register has to be even. It means that half of this number of slots are dedicated to the left channel and the other slots for the right channel (e.g: this bit has to be set for I2S or MSB/LSB-justified protocols...). This bit is meaningless and is not used in AC'97 or SPDIF audio block configuration. It must be configured when the audio block is disabled.
$00020000 constant SEC_SAI1_SAI_AFRCR_FSPOL                         \ Frame synchronization polarity. This bit is set and cleared by software. It is used to configure the level of the start of frame on the FS signal. It is meaningless and is not used in AC'97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
$00040000 constant SEC_SAI1_SAI_AFRCR_FSOFF                         \ Frame synchronization offset. This bit is set and cleared by software. It is meaningless and is not used in AC'97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.


\
\ @brief SAI slot register
\ Address offset: 0x10
\ Reset value: 0x00000000
\

$0000001f constant SEC_SAI1_SAI_ASLOTR_FBOFF                        \ First bit offset These bits are set and cleared by software. The value set in this bitfield defines the position of the first data transfer bit in the slot. It represents an offset value. In transmission mode, the bits outside the data field are forced to 0. In reception mode, the extra received bits are discarded. These bits must be set when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.
$000000c0 constant SEC_SAI1_SAI_ASLOTR_SLOTSZ                       \ Slot size This bits is set and cleared by software. The slot size must be higher or equal to the data size. If this condition is not respected, the behavior of the SAI is undetermined. Refer to for information on how to drive SD line. These bits must be set when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.
$00000f00 constant SEC_SAI1_SAI_ASLOTR_NBSLOT                       \ Number of slots in an audio frame. These bits are set and cleared by software. The value set in this bitfield represents the number of slots + 1 in the audio frame (including the number of inactive slots). The maximum number of slots is 16. The number of slots should be even if FSDEF bit in the SAI_xFRCR register is set. The number of slots must be configured when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.
$ffff0000 constant SEC_SAI1_SAI_ASLOTR_SLOTEN                       \ Slot enable. These bits are set and cleared by software. Each SLOTEN bit corresponds to a slot position from 0 to 15 (maximum 16 slots). The slot must be enabled when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.


\
\ @brief SAI interrupt mask register
\ Address offset: 0x14
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAI1_SAI_AIM_OVRUDRIE                        \ Overrun/underrun interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the OVRUDR bit in the SAI_xSR register is set.
$00000002 constant SEC_SAI1_SAI_AIM_MUTEDETIE                       \ Mute detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the MUTEDET bit in the SAI_xSR register is set. This bit has a meaning only if the audio block is configured in receiver mode.
$00000004 constant SEC_SAI1_SAI_AIM_WCKCFGIE                        \ Wrong clock configuration interrupt enable. This bit is set and cleared by software. This bit is taken into account only if the audio block is configured as a master (MODE[1] = 0) and NODIV = 0. It generates an interrupt if the WCKCFG flag in the SAI_xSR register is set. Note: This bit is used only in Free protocol mode and is meaningless in other modes.
$00000008 constant SEC_SAI1_SAI_AIM_FREQIE                          \ FIFO request interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the FREQ bit in the SAI_xSR register is set. Since the audio block defaults to operate as a transmitter after reset, the MODE bit must be configured before setting FREQIE to avoid a parasitic interrupt in receiver mode,
$00000010 constant SEC_SAI1_SAI_AIM_CNRDYIE                         \ Codec not ready interrupt enable (AC'97). This bit is set and cleared by software. When the interrupt is enabled, the audio block detects in the slot 0 (tag0) of the AC'97 frame if the Codec connected to this line is ready or not. If it is not ready, the CNRDY flag in the SAI_xSR register is set and an interrupt is generated. This bit has a meaning only if the AC'97 mode is selected through PRTCFG[1:0] bits and the audio block is operates as a receiver.
$00000020 constant SEC_SAI1_SAI_AIM_AFSDETIE                        \ Anticipated frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the AFSDET bit in the SAI_xSR register is set. This bit is meaningless in AC'97, SPDIF mode or when the audio block operates as a master.
$00000040 constant SEC_SAI1_SAI_AIM_LFSDETIE                        \ Late frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the LFSDET bit is set in the SAI_xSR register. This bit is meaningless in AC'97, SPDIF mode or when the audio block operates as a master.


\
\ @brief SAI status register
\ Address offset: 0x18
\ Reset value: 0x00000008
\

$00000001 constant SEC_SAI1_SAI_ASR_OVRUDR                          \ Overrun / underrun. This bit is read only. The overrun and underrun conditions can occur only when the audio block is configured as a receiver and a transmitter, respectively. It can generate an interrupt if OVRUDRIE bit is set in SAI_xIM register. This flag is cleared when the software sets COVRUDR bit in SAI_xCLRFR register.
$00000002 constant SEC_SAI1_SAI_ASR_MUTEDET                         \ Mute detection. This bit is read only. This flag is set if consecutive 0 values are received in each slot of a given audio frame and for a consecutive number of audio frames (set in the MUTECNT bit in the SAI_xCR2 register). It can generate an interrupt if MUTEDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets bit CMUTEDET in the SAI_xCLRFR register.
$00000004 constant SEC_SAI1_SAI_ASR_WCKCFG                          \ Wrong clock configuration flag. This bit is read only. This bit is used only when the audio block operates in master mode (MODE[1] = 0) and NODIV = 0. It can generate an interrupt if WCKCFGIE bit is set in SAI_xIM register. This flag is cleared when the software sets CWCKCFG bit in SAI_xCLRFR register.
$00000008 constant SEC_SAI1_SAI_ASR_FREQ                            \ FIFO request. This bit is read only. The request depends on the audio block configuration: If the block is configured in transmission mode, the FIFO request is related to a write request operation in the SAI_xDR. If the block configured in reception, the FIFO request related to a read request operation from the SAI_xDR. This flag can generate an interrupt if FREQIE bit is set in SAI_xIM register.
$00000010 constant SEC_SAI1_SAI_ASR_CNRDY                           \ Codec not ready. This bit is read only. This bit is used only when the AC'97 audio protocol is selected in the SAI_xCR1 register and configured in receiver mode. It can generate an interrupt if CNRDYIE bit is set in SAI_xIM register. This flag is cleared when the software sets CCNRDY bit in SAI_xCLRFR register.
$00000020 constant SEC_SAI1_SAI_ASR_AFSDET                          \ Anticipated frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC'97 or SPDIF mode. It can generate an interrupt if AFSDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets CAFSDET bit in SAI_xCLRFR register.
$00000040 constant SEC_SAI1_SAI_ASR_LFSDET                          \ Late frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC'97 or SPDIF mode. It can generate an interrupt if LFSDETIE bit is set in the SAI_xIM register. This flag is cleared when the software sets bit CLFSDET in SAI_xCLRFR register
$00070000 constant SEC_SAI1_SAI_ASR_FLVL                            \ FIFO level threshold. This bit is read only. The FIFO level threshold flag is managed only by hardware and its setting depends on SAI block configuration (transmitter or receiver mode). Others: Reserved


\
\ @brief SAI clear flag register
\ Address offset: 0x1C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAI1_SAI_ACLRFR_COVRUDR                      \ Clear overrun / underrun. This bit is write only. Programming this bit to 1 clears the OVRUDR flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000002 constant SEC_SAI1_SAI_ACLRFR_CMUTEDET                     \ Mute detection flag. This bit is write only. Programming this bit to 1 clears the MUTEDET flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000004 constant SEC_SAI1_SAI_ACLRFR_CWCKCFG                      \ Clear wrong clock configuration flag. This bit is write only. Programming this bit to 1 clears the WCKCFG flag in the SAI_xSR register. This bit is used only when the audio block is set as master (MODE[1] = 0) and NODIV = 0 in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000010 constant SEC_SAI1_SAI_ACLRFR_CCNRDY                       \ Clear Codec not ready flag. This bit is write only. Programming this bit to 1 clears the CNRDY flag in the SAI_xSR register. This bit is used only when the AC'97 audio protocol is selected in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000020 constant SEC_SAI1_SAI_ACLRFR_CAFSDET                      \ Clear anticipated frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the AFSDET flag in the SAI_xSR register. It is not used in AC'97 or SPDIF mode. Reading this bit always returns the value 0.
$00000040 constant SEC_SAI1_SAI_ACLRFR_CLFSDET                      \ Clear late frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the LFSDET flag in the SAI_xSR register. This bit is not used in AC'97 or SPDIF mode Reading this bit always returns the value 0.


\
\ @brief SAI data register
\ Address offset: 0x20
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAI1_SAI_ADR_DATA                            \ Data A write to this register loads the FIFO provided the FIFO is not full. A read from this register empties the FIFO if the FIFO is not empty.


\
\ @brief SAI configuration register 1
\ Address offset: 0x24
\ Reset value: 0x00000040
\

$00000003 constant SEC_SAI1_SAI_BCR1_MODE                           \ SAIx audio block mode These bits are set and cleared by software. They must be configured when SAIx audio block is disabled. Note: When the audio block is configured in SPDIF mode, the master transmitter mode is forced (MODE[1:0] = 00). In Master transmitter mode, the audio block starts generating the FS and the clocks immediately.
$0000000c constant SEC_SAI1_SAI_BCR1_PRTCFG                         \ Protocol configuration These bits are set and cleared by software. These bits have to be configured when the audio block is disabled.
$000000e0 constant SEC_SAI1_SAI_BCR1_DS                             \ Data size These bits are set and cleared by software. These bits are ignored when the SPDIF protocols are selected (bit PRTCFG[1:0]), because the frame and the data size are fixed in such case. When the companding mode is selected through COMP[1:0] bits, DS[1:0] are ignored since the data size is fixed to 8 bits by the algorithm. These bits must be configured when the audio block is disabled.
$00000100 constant SEC_SAI1_SAI_BCR1_LSBFIRST                       \ Least significant bit first This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in AC'97 audio protocol since AC'97 data are always transferred with the MSB first. This bit has no meaning in SPDIF audio protocol since in SPDIF data are always transferred with LSB first.
$00000200 constant SEC_SAI1_SAI_BCR1_CKSTR                          \ Clock strobing edge This bit is set and cleared by software. It must be configured when the audio block is disabled. This bit has no meaning in SPDIF audio protocol.
$00000c00 constant SEC_SAI1_SAI_BCR1_SYNCEN                         \ Synchronization enable These bits are set and cleared by software. They must be configured when the audio subblock is disabled. Note: The audio subblock should be configured as asynchronous when SPDIF mode is enabled.
$00001000 constant SEC_SAI1_SAI_BCR1_MONO                           \ Mono mode This bit is set and cleared by software. It is meaningful only when the number of slots is equal to 2. When the mono mode is selected, slot 0 data are duplicated on slot 1 when the audio block operates as a transmitter. In reception mode, the slot1 is discarded and only the data received from slot 0 are stored. Refer to for more details.
$00002000 constant SEC_SAI1_SAI_BCR1_OUTDRIV                        \ Output drive This bit is set and cleared by software. Note: This bit has to be set before enabling the audio block and after the audio block configuration.
$00010000 constant SEC_SAI1_SAI_BCR1_SAIEN                          \ Audio block enable This bit is set by software. To switch off the audio block, the application software must program this bit to 0 and poll the bit till it reads back 0, meaning that the block is completely disabled. Before setting this bit to 1, check that it is set to 0, otherwise the enable command is not taken into account. This bit allows controlling the state of the SAI audio block. If it is disabled when an audio frame transfer is ongoing, the ongoing transfer completes and the cell is fully disabled at the end of this audio frame transfer. Note: When the SAI block (A or B) is configured in master mode, the clock must be present on the SAI block input before setting SAIEN bit.
$00020000 constant SEC_SAI1_SAI_BCR1_DMAEN                          \ DMA enable This bit is set and cleared by software. Note: Since the audio block defaults to operate as a transmitter after reset, the MODE[1:0] bits must be configured before setting DMAEN to avoid a DMA request in receiver mode.
$00080000 constant SEC_SAI1_SAI_BCR1_NODIV                          \ No divider This bit is set and cleared by software.
$03f00000 constant SEC_SAI1_SAI_BCR1_MCKDIV                         \ Master clock divider These bits are set and cleared by software. Otherwise, The master clock frequency is calculated according to the formula given in . These bits have no meaning when the audio block is slave. They have to be configured when the audio block is disabled.
$04000000 constant SEC_SAI1_SAI_BCR1_OSR                            \ Oversampling ratio for master clock This bit is meaningful only when NODIV bit is set to 0.
$08000000 constant SEC_SAI1_SAI_BCR1_MCKEN                          \ Master clock generation enable


\
\ @brief SAI configuration register 2
\ Address offset: 0x28
\ Reset value: 0x00000000
\

$00000007 constant SEC_SAI1_SAI_BCR2_FTH                            \ FIFO threshold. This bit is set and cleared by software.
$00000008 constant SEC_SAI1_SAI_BCR2_FFLUSH                         \ FIFO flush. This bit is set by software. It is always read as 0. This bit should be configured when the SAI is disabled.
$00000010 constant SEC_SAI1_SAI_BCR2_TRIS                           \ Tristate management on data line. This bit is set and cleared by software. It is meaningful only if the audio block is configured as a transmitter. This bit is not used when the audio block is configured in SPDIF mode. It should be configured when SAI is disabled. Refer to for more details.
$00000020 constant SEC_SAI1_SAI_BCR2_MUTE                           \ Mute. This bit is set and cleared by software. It is meaningful only when the audio block operates as a transmitter. The MUTE value is linked to value of MUTEVAL if the number of slots is lower or equal to 2, or equal to 0 if it is greater than 2. Refer to for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00000040 constant SEC_SAI1_SAI_BCR2_MUTEVAL                        \ Mute value. This bit is set and cleared by software.It must be written before enabling the audio block: SAIEN. This bit is meaningful only when the audio block operates as a transmitter, the number of slots is lower or equal to 2 and the MUTE bit is set. If more slots are declared, the bit value sent during the transmission in mute mode is equal to 0, whatever the value of MUTEVAL. if the number of slot is lower or equal to 2 and MUTEVAL = 1, the MUTE value transmitted for each slot is the one sent during the previous frame. Refer to for more details. Note: This bit is meaningless and should not be used for SPDIF audio blocks.
$00001f80 constant SEC_SAI1_SAI_BCR2_MUTECNT                        \ Mute counter. These bits are set and cleared by software. They are used only in reception mode. The value set in these bits is compared to the number of consecutive mute frames detected in reception. When the number of mute frames is equal to this value, the flag MUTEDET is set and an interrupt is generated if bit MUTEDETIE is set. Refer to for more details.
$00002000 constant SEC_SAI1_SAI_BCR2_CPL                            \ Complement bit. This bit is set and cleared by software. It defines the type of complement to be used for companding mode Note: This bit has effect only when the companding mode is -Law algorithm or A-Law algorithm.
$0000c000 constant SEC_SAI1_SAI_BCR2_COMP                           \ Companding mode. These bits are set and cleared by software. The -Law and the A-Law log are a part of the CCITT G.711 recommendation, the type of complement that is used depends on CPL bit. The data expansion or data compression are determined by the state of bit MODE[0]. The data compression is applied if the audio block is configured as a transmitter. The data expansion is automatically applied when the audio block is configured as a receiver. Refer to for more details. Note: Companding mode is applicable only when Free protocol mode is selected.


\
\ @brief SAI frame configuration register
\ Address offset: 0x2C
\ Reset value: 0x00000007
\

$000000ff constant SEC_SAI1_SAI_BFRCR_FRL                           \ Frame length. These bits are set and cleared by software. They define the audio frame length expressed in number of SCK clock cycles: the number of bits in the frame is equal to FRL[7:0] + 1. The minimum number of bits to transfer in an audio frame must be equal to 8, otherwise the audio block behaves in an unexpected way. This is the case when the data size is 8 bits and only one slot 0 is defined in NBSLOT[4:0] of SAI_xSLOTR register (NBSLOT[3:0] = 0000). In master mode, if the master clock (available on MCLK_x pin) is used, the frame length should be aligned with a number equal to a power of 2, ranging from 8 to 256. When the master clock is not used (NODIV = 1), it is recommended to program the frame length to an value ranging from 8 to 256. These bits are meaningless and are not used in AC'97 or SPDIF audio block configuration.
$00007f00 constant SEC_SAI1_SAI_BFRCR_FSALL                         \ Frame synchronization active level length. These bits are set and cleared by software. They specify the length in number of bit clock (SCK) + 1 (FSALL[6:0] + 1) of the active level of the FS signal in the audio frame These bits are meaningless and are not used in AC'97 or SPDIF audio block configuration. They must be configured when the audio block is disabled.
$00010000 constant SEC_SAI1_SAI_BFRCR_FSDEF                         \ Frame synchronization definition. This bit is set and cleared by software. When the bit is set, the number of slots defined in the SAI_xSLOTR register has to be even. It means that half of this number of slots is dedicated to the left channel and the other slots for the right channel (e.g: this bit has to be set for I2S or MSB/LSB-justified protocols...). This bit is meaningless and is not used in AC'97 or SPDIF audio block configuration. It must be configured when the audio block is disabled.
$00020000 constant SEC_SAI1_SAI_BFRCR_FSPOL                         \ Frame synchronization polarity. This bit is set and cleared by software. It is used to configure the level of the start of frame on the FS signal. It is meaningless and is not used in AC'97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.
$00040000 constant SEC_SAI1_SAI_BFRCR_FSOFF                         \ Frame synchronization offset. This bit is set and cleared by software. It is meaningless and is not used in AC'97 or SPDIF audio block configuration. This bit must be configured when the audio block is disabled.


\
\ @brief SAI slot register
\ Address offset: 0x30
\ Reset value: 0x00000000
\

$0000001f constant SEC_SAI1_SAI_BSLOTR_FBOFF                        \ First bit offset These bits are set and cleared by software. The value set in this bitfield defines the position of the first data transfer bit in the slot. It represents an offset value. In transmission mode, the bits outside the data field are forced to 0. In reception mode, the extra received bits are discarded. These bits must be set when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.
$000000c0 constant SEC_SAI1_SAI_BSLOTR_SLOTSZ                       \ Slot size This bits is set and cleared by software. The slot size must be higher or equal to the data size. If this condition is not respected, the behavior of the SAI is undetermined. Refer to for information on how to drive SD line. These bits must be set when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.
$00000f00 constant SEC_SAI1_SAI_BSLOTR_NBSLOT                       \ Number of slots in an audio frame. These bits are set and cleared by software. The value set in this bitfield represents the number of slots + 1 in the audio frame (including the number of inactive slots). The maximum number of slots is 16. The number of slots should be even if FSDEF bit in the SAI_xFRCR register is set. The number of slots must be configured when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.
$ffff0000 constant SEC_SAI1_SAI_BSLOTR_SLOTEN                       \ Slot enable. These bits are set and cleared by software. Each SLOTEN bit corresponds to a slot position from 0 to 15 (maximum 16 slots). The slot must be enabled when the audio block is disabled. They are ignored in AC'97 or SPDIF mode.


\
\ @brief SAI interrupt mask register
\ Address offset: 0x34
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAI1_SAI_BIM_OVRUDRIE                        \ Overrun/underrun interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the OVRUDR bit in the SAI_xSR register is set.
$00000002 constant SEC_SAI1_SAI_BIM_MUTEDETIE                       \ Mute detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the MUTEDET bit in the SAI_xSR register is set. This bit has a meaning only if the audio block is configured in receiver mode.
$00000004 constant SEC_SAI1_SAI_BIM_WCKCFGIE                        \ Wrong clock configuration interrupt enable. This bit is set and cleared by software. This bit is taken into account only if the audio block is configured as a master (MODE[1] = 0) and NODIV = 0. It generates an interrupt if the WCKCFG flag in the SAI_xSR register is set. Note: This bit is used only in Free protocol mode and is meaningless in other modes.
$00000008 constant SEC_SAI1_SAI_BIM_FREQIE                          \ FIFO request interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the FREQ bit in the SAI_xSR register is set. Since the audio block defaults to operate as a transmitter after reset, the MODE bit must be configured before setting FREQIE to avoid a parasitic interrupt in receiver mode,
$00000010 constant SEC_SAI1_SAI_BIM_CNRDYIE                         \ Codec not ready interrupt enable (AC'97). This bit is set and cleared by software. When the interrupt is enabled, the audio block detects in the slot 0 (tag0) of the AC'97 frame if the Codec connected to this line is ready or not. If it is not ready, the CNRDY flag in the SAI_xSR register is set and an interrupt is generated. This bit has a meaning only if the AC'97 mode is selected through PRTCFG[1:0] bits and the audio block is operates as a receiver.
$00000020 constant SEC_SAI1_SAI_BIM_AFSDETIE                        \ Anticipated frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the AFSDET bit in the SAI_xSR register is set. This bit is meaningless in AC'97, SPDIF mode or when the audio block operates as a master.
$00000040 constant SEC_SAI1_SAI_BIM_LFSDETIE                        \ Late frame synchronization detection interrupt enable. This bit is set and cleared by software. When this bit is set, an interrupt is generated if the LFSDET bit is set in the SAI_xSR register. This bit is meaningless in AC'97, SPDIF mode or when the audio block operates as a master.


\
\ @brief SAI status register
\ Address offset: 0x38
\ Reset value: 0x00000008
\

$00000001 constant SEC_SAI1_SAI_BSR_OVRUDR                          \ Overrun / underrun. This bit is read only. The overrun and underrun conditions can occur only when the audio block is configured as a receiver and a transmitter, respectively. It can generate an interrupt if OVRUDRIE bit is set in SAI_xIM register. This flag is cleared when the software sets COVRUDR bit in SAI_xCLRFR register.
$00000002 constant SEC_SAI1_SAI_BSR_MUTEDET                         \ Mute detection. This bit is read only. This flag is set if consecutive 0 values are received in each slot of a given audio frame and for a consecutive number of audio frames (set in the MUTECNT bit in the SAI_xCR2 register). It can generate an interrupt if MUTEDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets bit CMUTEDET in the SAI_xCLRFR register.
$00000004 constant SEC_SAI1_SAI_BSR_WCKCFG                          \ Wrong clock configuration flag. This bit is read only. This bit is used only when the audio block operates in master mode (MODE[1] = 0) and NODIV = 0. It can generate an interrupt if WCKCFGIE bit is set in SAI_xIM register. This flag is cleared when the software sets CWCKCFG bit in SAI_xCLRFR register.
$00000008 constant SEC_SAI1_SAI_BSR_FREQ                            \ FIFO request. This bit is read only. The request depends on the audio block configuration: If the block is configured in transmission mode, the FIFO request is related to a write request operation in the SAI_xDR. If the block configured in reception, the FIFO request related to a read request operation from the SAI_xDR. This flag can generate an interrupt if FREQIE bit is set in SAI_xIM register.
$00000010 constant SEC_SAI1_SAI_BSR_CNRDY                           \ Codec not ready. This bit is read only. This bit is used only when the AC'97 audio protocol is selected in the SAI_xCR1 register and configured in receiver mode. It can generate an interrupt if CNRDYIE bit is set in SAI_xIM register. This flag is cleared when the software sets CCNRDY bit in SAI_xCLRFR register.
$00000020 constant SEC_SAI1_SAI_BSR_AFSDET                          \ Anticipated frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC'97or SPDIF mode. It can generate an interrupt if AFSDETIE bit is set in SAI_xIM register. This flag is cleared when the software sets CAFSDET bit in SAI_xCLRFR register.
$00000040 constant SEC_SAI1_SAI_BSR_LFSDET                          \ Late frame synchronization detection. This bit is read only. This flag can be set only if the audio block is configured in slave mode. It is not used in AC'97 or SPDIF mode. It can generate an interrupt if LFSDETIE bit is set in the SAI_xIM register. This flag is cleared when the software sets bit CLFSDET in SAI_xCLRFR register
$00070000 constant SEC_SAI1_SAI_BSR_FLVL                            \ FIFO level threshold. This bit is read only. The FIFO level threshold flag is managed only by hardware and its setting depends on SAI block configuration (transmitter or receiver mode). Others: Reserved


\
\ @brief SAI clear flag register
\ Address offset: 0x3C
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAI1_SAI_BCLRFR_COVRUDR                      \ Clear overrun / underrun. This bit is write only. Programming this bit to 1 clears the OVRUDR flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000002 constant SEC_SAI1_SAI_BCLRFR_CMUTEDET                     \ Mute detection flag. This bit is write only. Programming this bit to 1 clears the MUTEDET flag in the SAI_xSR register. Reading this bit always returns the value 0.
$00000004 constant SEC_SAI1_SAI_BCLRFR_CWCKCFG                      \ Clear wrong clock configuration flag. This bit is write only. Programming this bit to 1 clears the WCKCFG flag in the SAI_xSR register. This bit is used only when the audio block is set as master (MODE[1] = 0) and NODIV = 0 in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000010 constant SEC_SAI1_SAI_BCLRFR_CCNRDY                       \ Clear Codec not ready flag. This bit is write only. Programming this bit to 1 clears the CNRDY flag in the SAI_xSR register. This bit is used only when the AC'97 audio protocol is selected in the SAI_xCR1 register. Reading this bit always returns the value 0.
$00000020 constant SEC_SAI1_SAI_BCLRFR_CAFSDET                      \ Clear anticipated frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the AFSDET flag in the SAI_xSR register. It is not used in AC'97or SPDIF mode. Reading this bit always returns the value 0.
$00000040 constant SEC_SAI1_SAI_BCLRFR_CLFSDET                      \ Clear late frame synchronization detection flag. This bit is write only. Programming this bit to 1 clears the LFSDET flag in the SAI_xSR register. This bit is not used in AC'97or SPDIF mode Reading this bit always returns the value 0.


\
\ @brief SAI data register
\ Address offset: 0x40
\ Reset value: 0x00000000
\

$00000000 constant SEC_SAI1_SAI_BDR_DATA                            \ Data A write to this register loads the FIFO provided the FIFO is not full. A read from this register empties the FIFO if the FIFO is not empty.


\
\ @brief SAI PDM control register
\ Address offset: 0x44
\ Reset value: 0x00000000
\

$00000001 constant SEC_SAI1_SAI_PDMCR_PDMEN                         \ PDM enable This bit is set and cleared by software. This bit allows to control the state of the PDM interface block. Make sure that the SAI in already operating in TDM master mode before enabling the PDM interface.
$00000030 constant SEC_SAI1_SAI_PDMCR_MICNBR                        \ Number of microphones This bit is set and cleared by software. Note: It is not recommended to configure this field when PDMEN = 1.* The complete set of data lines might not be available for all SAI instances. Refer to for details.
$00000100 constant SEC_SAI1_SAI_PDMCR_CKEN1                         \ Clock enable of bitstream clock number 1 This bit is set and cleared by software. Note: It is not recommended to configure this bit when PDMEN = 1. SAI_CK1 might not be available for all SAI instances. Refer to implementation for details.
$00000200 constant SEC_SAI1_SAI_PDMCR_CKEN2                         \ Clock enable of bitstream clock number 2 This bit is set and cleared by software. Note: It is not recommended to configure this bit when PDMEN = 1. SAI_CK2 might not be available for all SAI instances. Refer to implementation for details.


\
\ @brief SAI PDM delay register
\ Address offset: 0x48
\ Reset value: 0x00000000
\

$00000007 constant SEC_SAI1_SAI_PDMDLY_DLYM1L                       \ Delay line adjust for first microphone of pair 1 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D1 line is available.Refer to to check if it is available.
$00000070 constant SEC_SAI1_SAI_PDMDLY_DLYM1R                       \ Delay line adjust for second microphone of pair 1 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D1 line is available.Refer to to check if it is available.
$00000700 constant SEC_SAI1_SAI_PDMDLY_DLYM2L                       \ Delay line for first microphone of pair 2 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D2 line is available.Refer to to check if it is available.
$00007000 constant SEC_SAI1_SAI_PDMDLY_DLYM2R                       \ Delay line for second microphone of pair 2 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D2 line is available.Refer to to check if it is available.
$00070000 constant SEC_SAI1_SAI_PDMDLY_DLYM3L                       \ Delay line for first microphone of pair 3 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D3 line is available.Refer to to check if it is available.
$00700000 constant SEC_SAI1_SAI_PDMDLY_DLYM3R                       \ Delay line for second microphone of pair 3 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D3 line is available.Refer to to check if it is available.
$07000000 constant SEC_SAI1_SAI_PDMDLY_DLYM4L                       \ Delay line for first microphone of pair 4 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D4 line is available.Refer to to check if it is available.
$70000000 constant SEC_SAI1_SAI_PDMDLY_DLYM4R                       \ Delay line for second microphone of pair 4 This bit is set and cleared by software. ... This field can be changed on-the-fly. Note: This field can be used only if D4 line is available.Refer to to check if it is available.


\
\ @brief Serial audio interface
\
$50015400 constant SEC_SAI1_SAI_GCR  \ offset: 0x00 : SAI global configuration register
$50015404 constant SEC_SAI1_SAI_ACR1  \ offset: 0x04 : SAI configuration register 1
$50015408 constant SEC_SAI1_SAI_ACR2  \ offset: 0x08 : SAI configuration register 2
$5001540c constant SEC_SAI1_SAI_AFRCR  \ offset: 0x0C : SAI frame configuration register
$50015410 constant SEC_SAI1_SAI_ASLOTR  \ offset: 0x10 : SAI slot register
$50015414 constant SEC_SAI1_SAI_AIM  \ offset: 0x14 : SAI interrupt mask register
$50015418 constant SEC_SAI1_SAI_ASR  \ offset: 0x18 : SAI status register
$5001541c constant SEC_SAI1_SAI_ACLRFR  \ offset: 0x1C : SAI clear flag register
$50015420 constant SEC_SAI1_SAI_ADR  \ offset: 0x20 : SAI data register
$50015424 constant SEC_SAI1_SAI_BCR1  \ offset: 0x24 : SAI configuration register 1
$50015428 constant SEC_SAI1_SAI_BCR2  \ offset: 0x28 : SAI configuration register 2
$5001542c constant SEC_SAI1_SAI_BFRCR  \ offset: 0x2C : SAI frame configuration register
$50015430 constant SEC_SAI1_SAI_BSLOTR  \ offset: 0x30 : SAI slot register
$50015434 constant SEC_SAI1_SAI_BIM  \ offset: 0x34 : SAI interrupt mask register
$50015438 constant SEC_SAI1_SAI_BSR  \ offset: 0x38 : SAI status register
$5001543c constant SEC_SAI1_SAI_BCLRFR  \ offset: 0x3C : SAI clear flag register
$50015440 constant SEC_SAI1_SAI_BDR  \ offset: 0x40 : SAI data register
$50015444 constant SEC_SAI1_SAI_PDMCR  \ offset: 0x44 : SAI PDM control register
$50015448 constant SEC_SAI1_SAI_PDMDLY  \ offset: 0x48 : SAI PDM delay register

